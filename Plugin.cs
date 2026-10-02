using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Rhythm;
using System.IO;
using UnityEngine.Video;

namespace FOUNDSIGNAL;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
      

    private void Awake()
    {
        // Plugin startup logic
        var harmony = new Harmony("FOUNDSIGNAL");
        harmony.PatchAll();
        Logger = base.Logger;
        Logger.LogInfo($"Signal has been found.");
    }
}

[HarmonyPatch(typeof(RhythmMVPlayer), "SetVideo")]
class Patch_LoadMusicVideo
{
    static ManualLogSource LoggerPatch = BepInEx.Logging.Logger.CreateLogSource("FOUNDSIGNAL");
    static void Postfix(ref VideoPlayer ___player, BeatmapIndex.Song ____song)
    {
        string videoDirectory = "BepInEx/plugins/FOUNDSIGNAL/Videos";
        string songFilePath = $"{videoDirectory}/{____song.name}.mp4";
        if (____song.name != "")
        {
            LoggerPatch.LogInfo("Attempting to find custom video for " + ____song.name);
            if (File.Exists(songFilePath))
            {
                LoggerPatch.LogInfo($"Loading custom video {songFilePath}");
                ___player.source = VideoSource.Url;
                ___player.url = Path.GetFullPath(songFilePath);
                ___player.Prepare();
            }
        }
    }
}