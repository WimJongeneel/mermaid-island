# Mermaid Island, a custom Stardew Valley location

<p align="center"><b>Work In Progress</b></p>

![image](/images/screenshot.png)

## Introduction

This is a mod that adds a custom location to the game (...)

## Install

- Install and configure the Stardew Valley mod loader: [SMAPI - Stardew Modding API](https://www.nexusmods.com/stardewvalley/mods/2400)
- Install [Content Patcher](https://www.nexusmods.com/stardewvalley/mods/1915), needed to load the custom content into the game
- Install [Train Station](https://www.nexusmods.com/stardewvalley/mods/6183), the island will be added as a destination to the train station. Make sure that you install the SV 1.6 compatable version, this is not the default download on Nexus
- Download the latest build [todo](/)
- Unzip the downloaded file into your `Stardew Valley\Mods` folder

## Build and run from source

- Install and configure the Stardew Valley mod loader: [SMAPI - Stardew Modding API](https://www.nexusmods.com/stardewvalley/mods/2400)
- Install [Content Patcher](https://www.nexusmods.com/stardewvalley/mods/1915), needed to load the custom content into the game
- Install [Train Station](https://www.nexusmods.com/stardewvalley/mods/6183), the island will be added as a destination to the train station. Make sure that you install the SV 1.6 compatable version, this is not the default download on Nexus
- Install dotnet
- Run `build.cmd` in the project root. This scripts asumes you installed Stardew Valley from Steam in the default location.

## Editing the map

- Make sure to have unpacked the games XNB files with [StardewXnbHack](https://github.com/Pathoschild/StardewXnbHack)
- Run `reset_map_source.cmd`, this will copy the tmx file to the unpacked content folder
- Open `C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Content (unpacked)\Maps\mermaid-island.tmx` in [Tiled](http://www.mapeditor.org/)
- You can now edit the map, see [Modding:Maps](https://stardewvalleywiki.com/Modding:Maps) and [Modding:Location_data](https://stardewvalleywiki.com/Modding:Location_data)
- When running `build.cmd` it will copy the tmx file from the unpacked content folder (when present) to the asset folder of the content pack