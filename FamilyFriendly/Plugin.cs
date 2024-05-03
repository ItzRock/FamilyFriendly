using BepInEx;
using System.IO;
using VoiceRecognitionAPI;
namespace FamilyFriendly {
    [ContentWarningPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_VERSION, true)]
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        readonly string path = $"{Paths.PluginPath}\\naughtywords.txt";
   
        void Kill(string msg) {
            Logger.LogInfo($"Bro said: {msg}");
            Player.KillLocal();
        }

        private void Awake() {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Logger.LogInfo($"ASSUMING PATH: {path}");
            // stolen https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/
            using (StreamReader file = new StreamReader(path)) {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null) {
                    Voice.ListenForPhrase(ln, Kill);
                    counter++;
                }
                file.Close();
            }
        }
    }
}
