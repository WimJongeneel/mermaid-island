using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewValley;

namespace MermaidIsland;

public class TileGrabHandler
{
    readonly Dictionary<string, Action> GrabHandlers = new();

    public void AddHandler(string action, Action handler)
    {
        GrabHandlers.Add(action, handler);
    }

    public void Input_ButtonPressed(object? sender, StardewModdingAPI.Events.ButtonPressedEventArgs e)
    {
        if (!Context.IsWorldReady) return;
        if (Game1.activeClickableMenu != null || (!Context.IsPlayerFree)) return;

        if (!Context.CanPlayerMove)
            return;

        if (!e.Button.IsActionButton())
            return;

        Vector2 grabTile = e.Cursor.GrabTile;

        string action = Game1.currentLocation.doesTileHaveProperty((int)grabTile.X, (int)grabTile.Y, "Action", "Buildings");

        if (action is not null && GrabHandlers.TryGetValue(action, out var handler))
        {
            handler?.Invoke();
        }
    }
}