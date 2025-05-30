# Warn
**The README file you are viewing may not be the latest version. If you want to get the latest information, please go to the simplified Chinese version of the readme file: [README.md](README.md)**

# Plants Vs. Zombies Launcher  
[简体中文](README.md) | [English](README.en.md)  

![Launcher Main Page](assets/Readme.md/mainpage.png)  

## Download  
You can download the latest version directly from the Releases section of the Github repository or Gitee mirror:  
Github Repository: [https://github.com/bilibilihuazi/PvzLauncher](https://github.com/bilibilihuazi/PvzLauncher)  
Gitee Mirror: [https://gitee.com/huamouren110/pvz-launcher](https://gitee.com/huamouren110/pvz-launcher)  
<br>  

Alternative download links (may not be the latest version):  
LanZou Cloud: [https://hhzyx.lanzouo.com/b00b4q0fxg Password:2cds](https://hhzyx.lanzouo.com/b00b4q0fxg)  
LanZou Cloud Premium: [https://www.ilanzou.com/s/6r4ZLvSU](https://www.ilanzou.com/s/6r4ZLvSU)  
123 Cloud Disk (Primary): [https://www.123865.com/s/9hDQjv-LJBn3](https://www.123865.com/s/9hDQjv-LJBn3)  
123 Cloud Disk (Backup): [https://www.123684.com/s/9hDQjv-LJBn3](https://www.123684.com/s/9hDQjv-LJBn3)  
huang1111 Cloud: [https://pan.huang1111.cn/s/mxK1os1](https://pan.huang1111.cn/s/mxK1os1)  

## Overview  
This launcher supports **launching and managing** the game.  

## Features  
### Version Management  
![Version Selection Interface](assets/Readme.md/selectgame.png)  
![Version Settings Interface](assets/Readme.md/setgame.png)  

The launcher allows quick **importing, managing, and launching** of games. It provides a GUI interface, making it easy for players unfamiliar with game file structures to operate.  

A statistics interface is also included, allowing users to **view playtime, first launch date**, and more.  

### Built-in Trainer  
![PvzToolkit Trainer](assets/Readme.md/trainer.png)  

The launcher includes a built-in trainer, eliminating the need to search for external tools. The settings menu offers an option to **launch the trainer automatically with the game**.  

### Save Management  
![Save Management Interface](assets/Readme.md/victorysave.png)  
![Game Interface](assets/Readme.md/game.png)  

The trainer also provides save management functionality, allowing users to **replace saves with completed ones** effortlessly.  

## Why This Launcher Was Created  
With numerous PVZ mods available, managing downloaded versions can be **challenging** due to **disorganized file structures**. Mod versions often have inconsistent file setups, requiring significant effort to launch. This launcher aims to simplify **launching and managing** games.  

Additionally, there are **no existing PVZ launchers** online, which motivated the creation of this tool. The built-in `PvzToolkit` trainer works with most game versions.  

## Version Numbering Rules  
Starting from `Release1.0.0.0`, versions follow these rules:  

Release version: `[Major].[Minor].[Pre-Release Count].[Change Count]`  
Pre-Release version: `[Target Major].[Target Minor].[Pre-Release ID].[Change Count]`  

| Term                | Description                                                                 |  
|---------------------|-----------------------------------------------------------------------------|  
| Major Version       | Increments when Minor Version reaches 10                                    |  
| Minor Version       | Increments per release, resets to 0 at 10, triggering Major Version increment|  
| Change Count        | Total number of changes in the version                                      |  
| Pre-Release Count   | Number of Pre-Release versions for the target Release                       |  
| Pre-Release ID      | Sequence number of the Pre-Release for the target Release                   |  

Examples:  
- A Release with Major `1`, Minor `1`, `1` Pre-Release, and `10` changes: `Release 1.1.10.3`.  
- A Pre-Release targeting Major `1`, Minor `2`, as the 3rd Pre-Release with `5` changes: `Pre-Release 1.2.5.2`.  

## Dependencies  
Built using `.NET Framework 4.8 WinForm`, with UI libraries `AntdUI` (primary) and `ReaLTaiizor` (secondary).  

The package includes DLLs for both UI libraries. Download the .NET Framework Runtime [here](https://dotnet.microsoft.com/zh-cn/download/dotnet-framework).  

## References  
[.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/zh-cn/download/dotnet-framework/net48)  
[AntdUI](https://gitee.com/antdui/AntdUI)  
[ReaLTaiizor](https://github.com/Taiizor/ReaLTaiizor)  

## Credits  
**Code (2):**  
1. **华某人** (Entire launcher code)  
2. **DeepSeek** (Partial custom functions)  

**UI (2):**  
1. **华某人** (Most UI elements)  
2. **PCL2** (Partial design inspiration)  

**Art (3):**  
1. **YesIcon** (Most icons) [Website↗](https://yesicon.app/)  
2. **华某人** (Partial image editing)  
3. **Plants Vs Zombies** (Minor images)  

**External Tools (2):**  
1. **PvzToolkit** (Built-in trainer)  
2. **PopCap Games** (Built-in game)  

**Contributors (2):**  
1. **ewrtuikh** (Identified critical bugs)  
2. **旅行者** (Provided feedback for Pre-Release 1.0.x.1)  
3. **Fantasy-幻梦** (Suggested improvements and reported bugs for Pre-Release 1.0.x.2+)  