# Plants Vs. Zombies Launcher  
[简体中文](README.md) | [English](README.en.md)


<font color="red">**Attention**<br>This README may not be the latest.  If you want to get the latest news, please switch to the Simplified Chinese version</font>


![Launcher Main Page](assets/Readme.md/mainpage.png)  

## Download  

You can download the latest version directly from the **Releases** section of this repository.  

Alternative download links (may not be the latest version):  
<br>  
**Lanzou Cloud**:  
**123 Cloud Main Link**:  
**123 Cloud Backup Link**:  
**huang1111 Cloud**:  
**Gitee Clone Repository**:  

## Overview  

This launcher supports **launching and managing** the game.  

## Features  

### Version Management  

![Version Selection Interface](assets/Readme.md/selectgame.png)  
![Version Settings Interface](assets/Readme.md/setgame.png)  

The launcher allows quick **importing, managing, and launching** of games. It provides a GUI interface, making operations **easy** even for players unfamiliar with game file structures.  

A statistics interface is also included to **track playtime** and other metrics.  

### Built-in Trainer  

![PvzToolkit Trainer](assets/Readme.md/trainer.png)  

The launcher includes a built-in trainer, eliminating the need to search for external tools. The settings menu offers an option to **auto-launch the trainer with the game**, simplifying the process further.  

### Save Management  

![Save Management Interface](assets/Readme.md/victorysave.png)  
![Game Interface](assets/Readme.md/game.png)  

The trainer also provides save management functionality, allowing users to **replace saves with completed game files** instantly.  

## Why This Launcher Was Created  

With numerous PVZ mods available, managing downloaded files can be **challenging** due to their **disorganized structures**. Launching mods often requires manual adjustments, which can be time-consuming. This launcher aims to streamline **game launching and management** for players.  

Additionally, there are **no existing PVZ-specific launchers** online, making this project unique. The integrated `Pvz Toolkit` trainer also supports modifications for most game versions.  

## Version Naming Rules  

Starting from `Release1.0.0.0`, versions follow this naming convention:  

**Release Version**: `[Major].[Minor].[Changes].[Pre-Release Count]`  
**Pre-Release Version**: `[Target Major].[Target Minor].[Changes].[Pre-Release ID]`  

| Field               | Description                                                                 |  
|---------------------|-----------------------------------------------------------------------------|  
| Major               | Increments when Minor reaches 10                                            |  
| Minor               | Increments with each release, resets to 0 at 10, triggering Major increment |  
| Changes             | Total number of operations in this version                                  |  
| Pre-Release Count   | Number of Pre-Release versions for this Release                             |  
| Pre-Release ID      | Sequence number of the Pre-Release version                                  |  

**Examples**:  
- A Release with Major=`1`, Minor=`1`, 10 changes, and 3 Pre-Releases: `Release 1.1.10.3`  
- A Pre-Release targeting Major=`1`, Minor=`2`, with 5 changes and ID=2: `Pre-Release 1.2.5.2`  

## Dependencies  

Built using `.NET Framework 4.8 WinForm`, with UI libraries `AntdUI` (primary) and `ReaLTaiizor` (secondary).  

The package includes DLLs for both UI libraries. Download the .NET Framework Runtime [here](https://dotnet.microsoft.com/zh-cn/download/dotnet-framework).  

## References  

[.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/zh-cn/download/dotnet-framework/net48)  
[AntdUI](https://gitee.com/antdui/AntdUI)  
[ReaLTaiizor](https://github.com/Taiizor/ReaLTaiizor)  

## Credits  

**Code (2)**:  
  1. **华某人** (Full launcher code)  
  2. **DeepSeek** (Custom function contributions)  

**UI (2)**:  
  1. **华某人** (Primary UI design)  
  2. **PCL2** (Inspiration for core structure and features)  

**Art (3)**:  
  1. **YesIcon** (Most icons) [Website↗](https://yesicon.app/)  
  2. **华某人** (Hand-drawn icons)  
  3. **Plants Vs. Zombies** (Game assets)  

**External Tools (2)**:  
  1. **PvzToolkit** (Built-in trainer)  
  2. **PopCap Games** (Game integration)  

**Contributors (2)**:  
  1. **小王** (Feedback and suggestions for Pre-Release 1.0.x.1)  
  2. **Fantasy-幻梦** (Feedback and suggestions for Pre-Release 1.0.x.2)  
