# Plants Vs. Zombies Launcher

![启动器主页面](assets/Readme.md/mainpage.png)


## 下载

可直接在此仓库的Release界面下载最新版本

也可以使用以下的下载链接，但不能保证是最新版本:<br><br>
蓝奏云:<br>
123云盘主链接:<br>
123云盘备用链接:<br>
huang1111网盘:<br>
Gitee克隆库:<br>


## 概述

此启动器支持**启动、管理**游戏


## 特点

### 管理版本

![选择版本界面](assets/Readme.md/selectgame.png)
![版本设置界面](assets/Readme.md/setgame.png)

本启动器可快捷地`导入、管理、启动`游戏；提供一个GUI交互界面，对游戏文件结构不熟悉的玩家也可以**轻松操作**

启动器还提供了一个统计信息界面，可以**查看自己的游玩时间**等


### 内置修改器

![PvzToolkit修改器](assets/Readme.md/trainer.png)

启动器内置一个修改器，不用再到处找修改器了；而且设置界面还提供了**修改器随游戏启动**的选项，也不用费劲去打开修改器了！


### 存档管理

![存档管理设置界面](assets/Readme.md/victorysave.png)
![游戏界面](assets/Readme.md/game.png)

修改器还提供了存档管理功能，不想打了可以直接**替换为已通关的存档**


## 为什么要制作这款启动器

现在的PVZ改版众多，下载下来**较难管理**，而且游戏文件过于**繁乱**。而且改版的文件结构不一，通常想要启动游戏都要花上一段时间；制作这款启动器就是为了让玩家们更好的**启动、管理**游戏

况且，现在网络上**没有任何一款PVZ启动器**，于是就只做了这款启动器

此启动器还内置了`Pvz Toolkit`修改器，可用于大部分版本的修改


## 版本号命名规则

自`Release1.0.0.0`起，每次版本发布将使用以下命名规则：

Release版本: `[大版本].[小版本].[更改数].[Pre-Release个数]`<br>
Pre-Release版本: `[目标Release大版本].[目标Release小版本].[更改数].[Pre-Release编号]`<br>

|项|值|
|-|-|
|大版本|大版本，小版本每到10时+1|
|小版本|每个版本发布+1，到10时归零，大版本+1|
|更改数|此版本所有操作个数|
|Pre-Release个数|此Release版本拥有几个Pre-Release版本|
|Pre-Release编号|目标Release的第几个Pre-Release版本|

示例：
 - 大版本为`1`，小版本为`1`的，拥有`1`个Pre-Release版本。共有`10`个操作数的Release版本；那么版本号为`Release 1.1.10.3`

 - 目标Release的大版本和小版本分别为`1`、`2`；此Pre-Release版本为目标Release版本的第三个Pre-Release版本，有`5`个操作数；那么版本号为`Pre-Release 1.2.5.2`


## 依赖

程序使用`.NET Framework 4.8 WinForm`内核制作，使用`AntdUI(大部分UI)`与`ReaLTaiizor(小部分UI)`UI库

程序包内已包含两款UI库的dll文件，.NET Framework Runtime 可[点击此处](https://dotnet.microsoft.com/zh-cn/download/dotnet-framework)前往下载


## 引用

[.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/zh-cn/download/dotnet-framework/net48)<br>
[AntdUI](https://gitee.com/antdui/AntdUI)<br>
[ReaLTaiizor](https://github.com/Taiizor/ReaLTaiizor)


## 制作人员名单

代码(2):
  1. **华某人** (启动器全部代码)
  2. **DeepSeek** (部分自定义函数)

UI(2):
  1. **华某人** (大部分UI)
  2. **PCL2** (主体构造以及主体功能灵感来源)

美术(3):
  1. **YesIcon** (大部分图标) [网站↗](https://yesicon.app/)
  2. **华某人** (小部分手绘图标)
  3. **Plants Vs Zombies** (小部分图片)

外部程序(2):
  1. **PvzToolkit** (启动器内置的修改器)
  2. **PopCap Games** (启动器内置的游戏)

提供建议(1):
  1. **小王** (提供部分建议)
