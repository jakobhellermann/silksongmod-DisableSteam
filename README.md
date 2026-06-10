# DisableSteam

A Hollow Knight: Silksong mod that decouples the game from Steam, letting it run without a
running Steam client.

## Effects

- **Runs without Steam.** No Steam client required to launch the game, the DRM relaunch check is
  skipped.
- **Saves use a different folder.** ⚠️ Without Steam, save games are stored under a `default/`
  folder instead of your Steam-account id folder. Existing Steam saves will appear missing and
  creating new saves will not override them. The folders live at:
  - **Windows:** `%USERPROFILE%/AppData/LocalLow/Team Cherry/Hollow Knight Silksong/default`
  - **macOS:** `~/Library/Application Support/unity.Team-Cherry.Silksong/default`
  - **Linux:** `~/.config/unity3d/Team Cherry/Hollow Knight Silksong/default` 
- **No achievements.** Achievement unlocks are no-ops
- **No Steam Deck detection.** UI and font overrides for steam deck are not applied
