using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using xTile;
using xTile.Layers;
using xTile.Tiles;

namespace MermaidIsland;

public class BridgeRepair
{
    readonly IMonitor Monitor;

    public BridgeRepair(TileGrabHandler tileGrabHandler, IMonitor monitor)
    {
        tileGrabHandler.AddHandler(Constants.MermaidIslandBridgeRepairAction, GrabHandler);
        Monitor = monitor;
    }

    void GrabHandler()
    {
        var responses = new List<Response>();

        if (Has10Wood)
        {
            responses.Add(new Response("Yes", "Yes"));
        }

        responses.Add(new Response("No", "Maybe later"));

        Game1.currentLocation.createQuestionDialogue("Do you want to repair the bridge for 10 wood?", responses.ToArray(), HandleResponse);
    }

    void HandleResponse(Farmer farmer, string answer)
    {
        if (answer == "Yes" && Has10Wood)
        {
            Game1.MasterPlayer.removeFirstOfThisItemFromInventory("388", 10);
            AddBridgeToMap(Game1.currentLocation.Map);
            Game1.MasterPlayer.mailReceived.Add(Constants.MermaidIslandBridgeRepairMailFlag);
        }
    }

    private bool Has10Wood => Game1.MasterPlayer?.Items?.Any(i => i is not null && i.ItemId == "388" && i.stack?.Value > 10) ?? false;

    private void AddBridgeToMap(Map map)
    {
        var backLayer = map.GetLayer("Back");

        backLayer.Tiles[27, 44] = new StaticTile(
            layer: backLayer,
            tileSheet: map.GetTileSheet("z-outdoors"),
            tileIndex: 1274,
            blendMode: BlendMode.Alpha
        );
        backLayer.Tiles[28, 44] = new StaticTile(
            layer: backLayer,
            tileSheet: map.GetTileSheet("z-outdoors"),
            tileIndex: 1274,
            blendMode: BlendMode.Alpha
        );
        backLayer.Tiles[29, 44] = new StaticTile(
            layer: backLayer,
            tileSheet: map.GetTileSheet("z-outdoors"),
            tileIndex: 1274,
            blendMode: BlendMode.Alpha
        );

        var buildingsLayer = map.GetLayer("Buildings");
        buildingsLayer.Tiles[27, 44] = new StaticTile(
            layer: buildingsLayer,
            tileSheet: map.GetTileSheet("z-outdoors"),
            tileIndex: 781,
            blendMode: BlendMode.Alpha
        );
        buildingsLayer.Tiles[28, 44] = new StaticTile(
            layer: buildingsLayer,
            tileSheet: map.GetTileSheet("z-outdoors"),
            tileIndex: 781,
            blendMode: BlendMode.Alpha
        );
        buildingsLayer.Tiles[29, 44] = new StaticTile(
            layer: buildingsLayer,
            tileSheet: map.GetTileSheet("z-outdoors"),
            tileIndex: 781,
            blendMode: BlendMode.Alpha
        );
    }
}