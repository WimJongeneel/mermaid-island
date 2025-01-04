using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace MermaidIsland;

public class ModEntry : Mod
{
    readonly TileGrabHandler TileGrabHandler = new();

    public override void Entry(IModHelper helper)
    {
        Logger.Init(Monitor);

        helper.Events.Input.ButtonPressed += TileGrabHandler.Input_ButtonPressed;

        var b = new BridgeRepair(TileGrabHandler, Monitor);
    }
}
