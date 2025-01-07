set cp_out_folder="C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\[CP] MermaidIsland"
set cp_folder=".\[CP] MermaidIsland"

set ts_out_folder="C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\[TrainStation] MermaidIsland"
set ts_folder=".\[TrainStation] MermaidIsland"

set map_src="C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Content (unpacked)\Maps\mermaid-island.tmx"
set map_target=".\[CP] MermaidIsland\assets"

dotnet build

if exist %map_src% copy /y %map_src% %map_target%

if exist %cp_out_folder% rmdir /s /q %cp_out_folder%
robocopy %cp_folder% %cp_out_folder% /e

if exist %ts_out_folder% rmdir /s /q %ts_out_folder%
robocopy %ts_folder% %ts_out_folder% /e