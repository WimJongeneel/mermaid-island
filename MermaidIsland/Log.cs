using StardewModdingAPI;

namespace MermaidIsland;

public static class Logger
{
    static IMonitor? Monitor;

    public static void Init(IMonitor monitor)
    {
        Monitor = monitor;
    }

    public static void Log(string msg)
    {
        if (Monitor is not null)
        {
            Monitor.Log(msg, LogLevel.Debug);
        }
    }
}