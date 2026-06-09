using BepInEx;
using HarmonyLib;
using SilksongPlayground.Source;

namespace SilksongPlayground;

// TODO - adjust the plugin guid as needed
[BepInAutoPlugin(id: "io.github.jakobhellermann.silksongplayground")]
public partial class SilksongPlaygroundPlugin : BaseUnityPlugin
{
    private Harmony harmony = null!;

    private void Awake() {
        Log.Init(Logger);
        Log.Info($"Plugin {Name} ({Id}) has loaded!");

        harmony = Harmony.CreateAndPatchAll(typeof(SilksongPlaygroundPlugin).Assembly);
    }

    private void OnDestroy()
    {
        // Clean up everything, in order to support hot reloading
        Log.Info($"Plugin {Name} ({Id}) has been unloaded!");

        harmony.UnpatchSelf();
    }
}
