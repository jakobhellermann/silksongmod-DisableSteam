using BepInEx;

namespace SilksongPlayground;

// TODO - adjust the plugin guid as needed
[BepInAutoPlugin(id: "io.github.yourgithubusername.silksongplayground")]
public partial class SilksongPlaygroundPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Put your initialization logic here
        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
    }
}
