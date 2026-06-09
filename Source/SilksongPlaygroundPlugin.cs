using BepInEx;
using SilksongPlayground.Source;

namespace SilksongPlayground;

// TODO - adjust the plugin guid as needed
[BepInAutoPlugin(id: "io.github.jakobhellermann.silksongplayground")]
public partial class SilksongPlaygroundPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        Log.Init(Logger);
        
        // Put your initialization logic here
        Log.Info($"Plugin {Name} ({Id}) has loaded!");
    }

    private void OnDestroy()
    {
        // Clean up everything, in order to support hot reloading
        Log.Info($"Plugin {Name} ({Id}) has been unloaded!");
    }
}
