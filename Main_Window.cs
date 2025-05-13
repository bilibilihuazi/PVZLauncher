using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;

namespace PVZLauncher
{
    public partial class Main_Window: AntdUI.Window
    {
        //函数========================================================================================
        #region Functions

        //引用==================================================
        //发送系统消息
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool DestroyIcon(IntPtr hIcon);

        //写PATH系统环境变量
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessageTimeout(
        IntPtr hWnd,
        uint Msg,
        UIntPtr wParam,
        string lParam,
        uint fuFlags,
        uint uTimeout,
        out UIntPtr lpdwResult);

        private const uint WM_SETTINGCHANGE = 0x001A;
        private const uint SMTO_ABORTIFHUNG = 0x0002;

        //创建快捷方式
        [ComImport]
        [Guid("00021401-0000-0000-C000-000000000046")]
        private class ShellLink { }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("000214F9-0000-0000-C000-000000000046")]
        private interface IShellLinkW
        {
            void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
            void GetIDList(out IntPtr ppidl);
            void SetIDList(IntPtr pidl);
            void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
            void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
            void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
            void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
            void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxArgs);
            void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
            void GetHotkey(out short pwHotkey);
            void SetHotkey(short wHotkey);
            void GetShowCmd(out int piShowCmd);
            void SetShowCmd(int iShowCmd);
            void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
            void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
            void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
            void Resolve(IntPtr hwnd, int fFlags);
            void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("0000010b-0000-0000-C000-000000000046")]
        private interface IPersistFile
        {
            void GetClassID(out Guid pClassID);
            [PreserveSig]
            int IsDirty();
            void Load([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, int dwMode);
            void Save([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.Bool)] bool fRemember);
            void SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string pszFileName);
            void GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);
        }
        //引用==================================================

        //HTTP读取文件
        public static string HttpReadFile(string url)
        {
            try
            {
                // 设置安全协议类型（支持TLS 1.2/1.1/1.0）
                ServicePointManager.SecurityProtocol =
                    SecurityProtocolType.Tls12 |
                    SecurityProtocolType.Tls11 |
                    SecurityProtocolType.Tls;

                // 创建带自定义验证的HttpClient
                using (var handler = new HttpClientHandler())
                using (var client = new HttpClient(handler))
                {
                    // 忽略SSL证书验证
                    handler.ServerCertificateCustomValidationCallback =
                        (sender, cert, chain, sslPolicyErrors) => true;

                    // 设置超时时间（10秒）
                    client.Timeout = TimeSpan.FromSeconds(10);

                    // 添加浏览器User-Agent
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                        "(KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                    // 发送GET请求
                    var response = client.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();

                    // 读取字节内容
                    var bytes = response.Content.ReadAsByteArrayAsync().Result;

                    // 检测编码
                    var encoding = HttpReadFile_DetectEncoding(response, bytes);

                    // 转换为字符串
                    return encoding.GetString(bytes);
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        //HTTPS读文件(检测编码)
        private static Encoding HttpReadFile_DetectEncoding(HttpResponseMessage response, byte[] bytes)
        {
            try
            {
                // 从Content-Type头获取编码
                var contentType = response.Content.Headers.ContentType;
                if (contentType?.CharSet != null)
                {
                    return Encoding.GetEncoding(contentType.CharSet);
                }
            }
            catch
            {
                // 忽略编码解析错误
            }

            // 尝试通过BOM检测编码
            if (bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF)
                return Encoding.UTF8;
            if (bytes.Length >= 2 && bytes[0] == 0xFE && bytes[1] == 0xFF)
                return Encoding.BigEndianUnicode;
            if (bytes.Length >= 2 && bytes[0] == 0xFF && bytes[1] == 0xFE)
                return Encoding.Unicode;

            // 默认使用UTF-8
            return Encoding.UTF8;
        }

        //写日志
        public static void Log(string level, string message)
        {
            // 获取当前时间并格式化
            string timestamp = DateTime.Now.ToString("HH:mm:ss");

            // 构造完整日志条目
            string logContent = $"[{timestamp}][{level}]: {message}";

            // 拼接完整文件路径
            string logPath = Path.Combine(Application.StartupPath, "Log.log");

            // 使用追加模式写入文件
            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine(logContent);
            }

        }

        //文件写一行
        public static void FileAddLine(string content, string filePath)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(content);
            }
        }

        //连通性测试
        public static object CheckUrlConnection(string url)
        {
            // 验证URL格式有效性
            try
            {
                var uri = new Uri(url);
            }
            catch (UriFormatException)
            {
                return "unconnect";
            }

            HttpWebRequest request = null;
            Stopwatch sw = new Stopwatch();

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 5000;     // 设置5秒超时
                request.Method = "HEAD";     // 使用HEAD方法减少数据量

                sw.Start();
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    sw.Stop();
                    return sw.ElapsedMilliseconds;
                }
            }
            catch (WebException ex)
            {
                sw.Stop();
                /* 服务器响应但返回错误状态（如404）的情况
                   仍视为连接成功，返回延迟时间 */
                if (ex.Response != null)
                {
                    return sw.ElapsedMilliseconds;
                }
                return "unconnect"; // 真正无法连接的情况
            }
            catch (Exception)
            {
                return "unconnect";
            }
            finally
            {
                request?.Abort(); // 确保释放网络资源
            }
        }

        //执行控制台命令
        public string ExecuteCommand(string command)
        {
            try
            {
                var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
                {
                    CreateNoWindow = false,          // 不创建新窗口
                    UseShellExecute = false,        // 不使用系统外壳程序执行
                    RedirectStandardError = true,   // 重定向标准错误
                    RedirectStandardOutput = true   // 重定向标准输出
                };

                using (var process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();

                    // 异步读取输出流和错误流
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();  // 等待程序执行完成

                    // 组合输出结果
                    string result = string.IsNullOrEmpty(output) ? "" : output;
                    string errorResult = string.IsNullOrEmpty(error) ? "" : "\n[Error]\n" + error;

                    return $"{result}{errorResult} (ExitCode: {process.ExitCode})";
                }
            }
            catch (Exception ex)
            {
                return $"执行命令时发生异常：{ex.Message}";
            }
        }

        //搜索文件内容
        public bool FileSearchText(string filePath, string searchText)
        {
            try
            {
                // 检查搜索文本是否有效
                if (string.IsNullOrEmpty(searchText))
                    return false;

                // 读取文件全部内容
                string fileContent = File.ReadAllText(filePath);

                // 检查内容是否包含目标文本
                return fileContent.Contains(searchText);
            }
            catch (Exception ex) when (ex is FileNotFoundException ||
                                      ex is IOException ||
                                      ex is UnauthorizedAccessException)
            {
                // 处理常见文件异常：文件不存在、无法访问或IO错误
                return false;
            }
        }

        //弹出系统通知
        public static void ShowNotification(string title, string content)
        {
            NotifyIcon notifyIcon = new NotifyIcon();

            // 创建透明图标
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                bmp.SetPixel(0, 0, Color.Transparent);
                IntPtr hIcon = bmp.GetHicon();
                try
                {
                    notifyIcon.Icon = Icon.FromHandle(hIcon);
                }
                finally
                {
                    DestroyIcon(hIcon);
                }
            }

            notifyIcon.Visible = true;

            // 设置通知关闭后的清理操作
            notifyIcon.BalloonTipClosed += (sender, e) =>
            {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            };

            // 显示通知（3000ms=3秒显示时间）
            notifyIcon.ShowBalloonTip(3000, title, content, ToolTipIcon.None);
        }

        // 写入配置（常规）
        public static void Legacy_WriteConfig(string filePath, string key, string value)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();

            // 如果文件存在，先读取现有配置
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] parts = line.Split(new[] { '=' }, 2);
                    if (parts.Length == 2 && !string.IsNullOrWhiteSpace(parts[0]))
                    {
                        config[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }

            // 添加/更新键值
            config[key] = value;

            // 写入所有配置项
            File.WriteAllLines(filePath,
                config.Select(kvp => $"{kvp.Key}={kvp.Value}"),
                Encoding.UTF8);
        }

        // 读取配置（常规）
        public static string Legacy_ReadConfig(string filePath, string key)
        {
            if (!File.Exists(filePath)) return null;

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(new[] { '=' }, 2);
                if (parts.Length == 2 &&
                    parts[0].Trim().Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    return parts[1].Trim();
                }
            }
            return null;
        }

        //写注册表项
        //rootKey常用常量
        //Registry.CurrentUser (HKEY_CURRENT_USER)
        //Registry.LocalMachine (HKEY_LOCAL_MACHINE)
        //Registry.ClassesRoot (HKEY_CLASSES_ROOT)

        /*valueKind：支持的类型包括：
        String：字符串值
        DWord：32位整数
        QWord：64位整数
        Binary：二进制数据
        MultiString：字符串数组*/
        public static bool WriteRegistryValue(RegistryKey rootKey, string subKeyPath, string valueName, object value, RegistryValueKind valueKind)
        {
            try
            {
                if (rootKey == null)
                    throw new ArgumentNullException(nameof(rootKey));

                if (string.IsNullOrEmpty(subKeyPath))
                    throw new ArgumentException("子项路径不能为空", nameof(subKeyPath));

                using (RegistryKey subKey = rootKey.CreateSubKey(subKeyPath))
                {
                    if (subKey == null) return false;

                    subKey.SetValue(valueName, value, valueKind);
                    return true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                // 权限不足，可能需要以管理员身份运行
                throw;
            }
            catch (Exception ex)
            {
                // 记录异常或处理其他错误
                Console.WriteLine($"写入注册表失败: {ex.Message}");
                return false;
            }
        }

        //读注册表项
        public static object ReadRegistryValue(RegistryKey rootKey, string subKeyPath, string valueName, object defaultValue = null)
        {
            try
            {
                if (rootKey == null)
                    throw new ArgumentNullException(nameof(rootKey));

                if (string.IsNullOrEmpty(subKeyPath))
                    throw new ArgumentException("子项路径不能为空", nameof(subKeyPath));

                using (RegistryKey subKey = rootKey.OpenSubKey(subKeyPath, false))
                {
                    // 子项不存在时返回默认值
                    if (subKey == null) return defaultValue;

                    // 获取值（值不存在时返回默认值）
                    return subKey.GetValue(valueName, defaultValue);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // 权限不足，可能需要管理员权限
                throw;
            }
            catch (Exception ex)
            {
                // 记录异常或处理其他错误
                Console.WriteLine($"读取注册表失败: {ex.Message}");
                return defaultValue;
            }
        }

        // 写入配置（支持节）
        public static void WriteConfig(string filePath, string section, string key, string value)
        {
            var sections = ParseConfigFile(filePath);

            // 创建或更新节
            if (!sections.ContainsKey(section))
            {
                sections[section] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            }

            // 更新键值
            sections[section][key.Trim()] = value;

            // 生成配置文件内容
            var lines = new List<string>();

            // 处理默认节（空节名）
            if (sections.TryGetValue("", out var defaultSection) && defaultSection.Count > 0)
            {
                lines.AddRange(defaultSection.Select(kvp => $"{kvp.Key}={kvp.Value}"));
            }

            // 处理带节名的配置（按字母顺序排序）
            foreach (var sec in sections.Keys
                .Where(s => !string.IsNullOrEmpty(s))
                .OrderBy(s => s, StringComparer.OrdinalIgnoreCase))
            {
                // 添加节分隔空行
                if (lines.Count > 0) lines.Add("");

                lines.Add($"[{sec}]");
                lines.AddRange(sections[sec].Select(kvp => $"{kvp.Key}={kvp.Value}"));
            }

            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        // 读取配置（支持节）
        public static string ReadConfig(string filePath, string section, string key)
        {
            if (!File.Exists(filePath)) return null;

            var sections = ParseConfigFile(filePath);

            if (sections.TryGetValue(section, out var sectionData) &&
                sectionData.TryGetValue(key, out var value))
            {
                return value;
            }
            return null;
        }

        // 解析配置文件为节字典(读写配置)
        private static Dictionary<string, Dictionary<string, string>> ParseConfigFile(string filePath)
        {
            var sections = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
            string currentSection = "";

            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var trimmed = line.Trim();

                    // 处理节头
                    if (trimmed.StartsWith("[") && trimmed.EndsWith("]"))
                    {
                        currentSection = trimmed.Substring(1, trimmed.Length - 2).Trim();
                        if (!sections.ContainsKey(currentSection))
                        {
                            sections[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                        }
                        continue;
                    }

                    // 处理键值对
                    var parts = line.Split(new[] { '=' }, 2);
                    if (parts.Length == 2 && !string.IsNullOrWhiteSpace(parts[0]))
                    {
                        var k = parts[0].Trim();
                        var v = parts[1].Trim();

                        if (!sections.ContainsKey(currentSection))
                        {
                            sections[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                        }

                        sections[currentSection][k] = v;
                    }
                }
            }
            return sections;
        }

        //写PATH系统环境变量
        public static void AddPath(string directoryPath, bool systemLevel = true)
        {
            if (string.IsNullOrWhiteSpace(directoryPath))
                throw new ArgumentException("目录路径不能为空");

            RegistryKey registryKey = systemLevel ?
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", true) :
                Registry.CurrentUser.OpenSubKey(@"Environment", true);

            if (registryKey == null)
                throw new NullReferenceException("注册表项未找到");

            try
            {
                string currentPath = registryKey.GetValue("PATH", "", RegistryValueOptions.DoNotExpandEnvironmentNames).ToString();
                string[] paths = currentPath.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                // 检查是否已存在（不区分大小写）
                if (paths.Any(p => p.Trim().Equals(directoryPath.Trim(), StringComparison.OrdinalIgnoreCase)))
                    return;

                // 追加新路径
                string newPath = currentPath.TrimEnd(';') + ";" + directoryPath.Trim();

                // 更新注册表
                registryKey.SetValue("PATH", newPath, RegistryValueKind.ExpandString);

                // 广播环境变量变更通知
                SendMessageTimeout(
                    new IntPtr(0xFFFF), // HWND_BROADCAST
                    WM_SETTINGCHANGE,
                    UIntPtr.Zero,
                    "Environment",
                    SMTO_ABORTIFHUNG,
                    5000,
                    out UIntPtr _);
            }
            finally
            {
                registryKey.Close();
            }
        }

        //创建快捷方式
        public static bool CreateShortcut(string targetPath, string shortcutPath)
        {
            if (!File.Exists(targetPath)) return false;

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(shortcutPath));

                var shellLink = (IShellLinkW)new ShellLink();
                shellLink.SetPath(targetPath);
                shellLink.SetWorkingDirectory(Path.GetDirectoryName(targetPath));
                shellLink.SetIconLocation(targetPath, 0);  // 使用目标文件自身图标

                var persistFile = (IPersistFile)shellLink;
                persistFile.Save(shortcutPath, false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //程序自启动
        public static bool SetAutoStart(bool enable, string exePath = null, RegistryKey registryRoot = null, string keyName = null)
        {
            try
            {
                // 设置默认值
                exePath = exePath ?? Application.ExecutablePath;
                registryRoot = registryRoot ?? Registry.CurrentUser;
                keyName = keyName ?? Application.ProductName;

                // 获取注册表Run子项
                using (var runKey = registryRoot.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run",
                    true)) // 需要写权限
                {
                    if (runKey == null)
                    {
                        throw new Exception("无法打开注册表Run项");
                    }

                    if (enable)
                    {
                        // 设置自启动
                        runKey.SetValue(keyName, exePath);
                    }
                    else
                    {
                        // 移除自启动
                        runKey.DeleteValue(keyName, throwOnMissingValue: false);
                    }
                }
                return true;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"需要管理员权限才能修改系统级自启动设置\n{ex.Message}");
                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"访问被拒绝，请以管理员身份运行\n{ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"操作失败: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 检查当前自启动状态
        /// </summary>
        public static bool IsAutoStartEnabled(RegistryKey registryRoot = null,
                                            string keyName = null)
        {
            try
            {
                registryRoot = registryRoot ?? Registry.CurrentUser;
                keyName = keyName ?? Application.ProductName;

                using (var runKey = registryRoot.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run"))
                {
                    var value = runKey?.GetValue(keyName);
                    return value != null && value.ToString().Equals(
                        Application.ExecutablePath,
                        StringComparison.OrdinalIgnoreCase);
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        //标题缓入
        public async void TitleFadeIn(int speed = 8)
        {
            pictureBox_Home_Title.Left = tabPage_Home.Width / 2 - pictureBox_Home_Title.Width / 2;
            pictureBox_Home_Title.Top = 0 - pictureBox_Home_Title.Height;

            for (int i = 0; i < pictureBox_Home_Title.Height / speed; i++)
            {
                pictureBox_Home_Title.Top = pictureBox_Home_Title.Top + speed;
                await Task.Delay(1);
            }
            pictureBox_Home_Title.Top = pictureBox_Home_Title.Top + 5;
            await Task.Delay(1);
            pictureBox_Home_Title.Top = pictureBox_Home_Title.Top + 5;
            await Task.Delay(1);

            for (int i = 0; i < 10; i++)
            {
                pictureBox_Home_Title.Top = pictureBox_Home_Title.Top - 1;
                await Task.Delay(1);
            }
        }

        //加载游戏列表
        public void LoadGameList()
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < Directory.GetDirectories($"{RunPath}\\games").Length; i++)
            {
                temp.Add(Path.GetFileName(Directory.GetDirectories($"{RunPath}\\games")[i]));
            }
            GamesPath = temp.ToArray();

        }

        //对象========================================================================================
        Random random = new Random();
        SelectGame_Window selectGame_Window = new SelectGame_Window();
        SetGame_Window setGame_Window = new SetGame_Window();
        Process proceess = new Process();
        //变量========================================================================================
        public static string Title = "Plants vs. Zombies Launcher";    //窗口标题
        public static string Version = "Alpha 1.1.3.7";    //版本
        public static string CompliedTime = "2025-5-13 20:21";     //编译时间
        public static string RunPath = Directory.GetCurrentDirectory();     //运行目录
        public static string ConfigPath = $"{RunPath}\\config\\config.ini";    //配置文件目录
        public static string[] GamesPath;    //游戏列表
        public static string SGamesPath;    //当前游戏路径
        public static int EggNum = 0;    //菜单计数器
        //事件========================================================================================
        public Main_Window()
        {
            InitializeComponent();

            pageHeader.Text = $"{Title}";

            LoadGameList();
            
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            TitleFadeIn();
            label_About_info3.Text = $"版本:{Version}  编译时间:{CompliedTime}";


            //初始化配置文件
            if (!Directory.Exists($"{RunPath}\\config"))
            {
                Directory.CreateDirectory($"{RunPath}\\config");
            }

            if (!File.Exists(ConfigPath))
            {
                WriteConfig(ConfigPath, "global", "SelectGame", "");
            }


            //读配置项
            SGamesPath = ReadConfig(ConfigPath, "global", "SelectGame");


        }

        private void tabs_Main_SelectedIndexChanged(object sender, AntdUI.IntEventArgs e)
        {
            if (tabs_Main.SelectedIndex == 0)
            {
                TitleFadeIn();
            }
        }

        private void button_SelectGame_Click(object sender, EventArgs e)
        {
            selectGame_Window.ShowDialog();
        }

        private void timer_Main_Tick(object sender, EventArgs e)
        {
            label_Home_Gamename.Text = $"当前版本:{SGamesPath}";
        }

        private async void button_Launch_Click(object sender, EventArgs e)
        {
            #region 启动/结束游戏

            proceess.StartInfo.FileName = $"{RunPath}\\games\\{SGamesPath}\\PlantsVsZombies.exe";

            if (button_Launch.Text == "启动游戏")
            {
                try
                {
                    button_Launch.Text = "结束进程";
                    button_Launch.Type = AntdUI.TTypeMini.Error;
                    button_Launch.Icon = Properties.Resources.close;

                    button_GameSettings.Enabled = false;
                    button_SelectGame.Enabled = false;


                    proceess.Start();

                    AntdUI.Notification.open(new AntdUI.Notification.Config(this, "", "", AntdUI.TType.None, AntdUI.TAlignFrom.TR)
                    {
                        Title = "成功启动！",
                        Text = $"游戏{SGamesPath}成功启动！",
                        Icon = AntdUI.TType.Success
                    });




                    await Task.Run(() => proceess.WaitForExit());
                    button_Launch.Text = "启动游戏";
                    button_Launch.Type = AntdUI.TTypeMini.Success;
                    button_Launch.Icon = Properties.Resources.launch;

                    button_GameSettings.Enabled = true;
                    button_SelectGame.Enabled = true;

                    AntdUI.Notification.open(new AntdUI.Notification.Config(this, "", "", AntdUI.TType.None, AntdUI.TAlignFrom.TR)
                    {
                        Title = "进程已退出",
                        Text = $"游戏{SGamesPath}已退出!",
                        Icon = AntdUI.TType.Info
                    });
                }
                catch (Exception ex)
                {
                    AntdUI.Notification.open(new AntdUI.Notification.Config(this, "", "", AntdUI.TType.None, AntdUI.TAlignFrom.TR)
                    {
                        Title = "发生错误！",
                        Text = $"在启动游戏进程时发生错误！\n错误原因:{ex.Message}",
                        Icon = AntdUI.TType.Error
                    });

                    button_Launch.Text = "启动游戏";
                    button_Launch.Type = AntdUI.TTypeMini.Success;
                    button_Launch.Icon = Properties.Resources.launch;

                    button_GameSettings.Enabled = true;
                    button_SelectGame.Enabled = true;

                    AntdUI.Notification.open(new AntdUI.Notification.Config(this, "", "", AntdUI.TType.None, AntdUI.TAlignFrom.TR)
                    {
                        Title = "进程已退出",
                        Text = $"游戏{SGamesPath}已退出!",
                        Icon = AntdUI.TType.Info
                    });
                }
                
            }
            else
            {
                if (!proceess.HasExited)
                {
                    try
                    {
                        button_Launch.Text = "启动游戏";
                        button_Launch.Type = AntdUI.TTypeMini.Success;
                        button_Launch.Icon = Properties.Resources.launch;

                        button_GameSettings.Enabled = true;
                        button_SelectGame.Enabled = true;

                        proceess.Kill();
                    }
                    catch (Exception ex)
                    {

                        AntdUI.Notification.open(new AntdUI.Notification.Config(this, "", "", AntdUI.TType.None, AntdUI.TAlignFrom.TR)
                        {
                            Title = "发生错误！",
                            Text = $"在结束游戏进程时发生错误！\n错误原因:{ex.Message}",
                            Icon = AntdUI.TType.Error
                        });
                       
                    }
                }
                
            }

            #endregion
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region 彩蛋
            EggNum = EggNum + 1;
            if (EggNum == 10)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "你是听说这里有一个彩蛋才来点的对吧",
                    Icon = AntdUI.TType.Info,
                    ShowInWindow = true
                });
            }
            else if (EggNum == 20)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "听着，这里没有彩蛋，彩蛋在其他地方",
                    Icon = AntdUI.TType.Warn,
                    ShowInWindow = true
                });
            }
            else if (EggNum == 50)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "我不是说了这里没有彩蛋了吗，不要再点了，你把鼠标点烂也不会有彩蛋",
                    Icon = AntdUI.TType.Warn,
                    ShowInWindow = true
                });
            }
            else if (EggNum == 70)
            {
                AntdUI.Notification.open(new AntdUI.Notification.Config(this, "", "", AntdUI.TType.None, AntdUI.TAlignFrom.TR)
                {
                    Title = "发生错误！",
                    Text = "在程序正常运行时发生错误！\n返回的错误原因为: 系统找不到指定文件",
                    Icon = AntdUI.TType.Error
                });
            }
            else if (EggNum == 90)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "好吧，这也骗不到你。",
                    Icon = AntdUI.TType.Info,
                    ShowInWindow = true
                });
            }
            else if (EggNum == 100)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "恭喜！100次点击",
                    Icon = AntdUI.TType.Success,
                    ShowInWindow = true
                });
            }
            else if (EggNum == 120)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "好吧实话告诉你，彩蛋确实是这个，但是只是这些弹窗而已。",
                    Icon = AntdUI.TType.Info,
                    ShowInWindow = true
                });
            }
            else if (EggNum == 160)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "好了，到此为止，彩蛋做这么多就没了，后面就没了",
                    Icon = AntdUI.TType.Warn,
                    ShowInWindow = true
                });
            }
            else if (EggNum == 2147483647)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this, "", AntdUI.TType.None)
                {
                    Text = "不，你不可能到这里。你一定是使用了连点器？正常人平均6CPS，点到这里需要11.3年。这是不可能的(或者使用CE修改器修改的？！)",
                    Icon = AntdUI.TType.Info,
                    ShowInWindow = true
                });
            }
            else if (1 > 2 && 2 < 1)
            {
                //你一定是翻看代码才看到这段话的对吧，正常操作根本无法到达此分支。即使你使用了CE修改器
            }

            #endregion
        }

        private void button_LaunchTrainer_Click(object sender, EventArgs e)
        {
            Process.Start($"{RunPath}\\trainer\\PvzToolkit_1.22.0.exe");
        }

        private void button_GameSettings_Click(object sender, EventArgs e)
        {
            setGame_Window.ShowDialog();
        }
    }
}
