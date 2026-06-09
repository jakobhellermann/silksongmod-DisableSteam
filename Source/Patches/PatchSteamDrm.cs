// ReSharper disable InconsistentNaming

using HarmonyLib;

namespace DisableSteam.Source.Patches;

[HarmonyPatch]
internal static class PatchSteamDrm {
    [HarmonyPatch(typeof(SteamOnlineSubsystem), nameof(SteamOnlineSubsystem.IsPackaged))]
    [HarmonyPrefix]
    private static bool IsPackaged(ref bool __result) {
        Log.Info("Prevented Steam DRM");
        __result = false;
        return false;
    }
}
