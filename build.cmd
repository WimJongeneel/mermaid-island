set cp_out_folder="C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\[CP] FlowerGarden"
set cp_folder=".\[CP] FlowerGarden"

set ts_out_folder="C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\[TrainStation] FlowerGarden"
set ts_folder=".\[TrainStation] FlowerGarden"

set map_src="C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Content (unpacked)\Maps\flower-garden.tmx"
set map_target=".\[CP] FlowerGarden\assets"

dotnet build

copy /y %map_src% %map_target%

if exist %cp_out_folder% rmdir /s /q %cp_out_folder%
robocopy %cp_folder% %cp_out_folder% /e

if exist %ts_out_folder% rmdir /s /q %ts_out_folder%
robocopy %ts_folder% %ts_out_folder% /e