using BepInEx;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using VoiceRecognitionAPI;
namespace FamilyFriendly {
    [ContentWarningPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_VERSION, true)]
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        readonly string filename = $"naughtywords.txt";
   
        void Kill(string msg) {
            Logger.LogInfo($"Bro said: {msg}");
            Player.KillLocal();
        }

        private void Awake() {
            // Plugin startup logic
            Logger.LogInfo($"Searching folder: {Paths.PluginPath}");
            List<string> files = Directory.GetFiles(Paths.PluginPath, filename, SearchOption.AllDirectories).ToList();
            if(files.Count < 1) { Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} failed to load! Missing {filename}"); return; }
            for(int i = 0; i < files.Count; i++){
                string path = files[i];
                Logger.LogInfo($"LOADING PATH: {path}");
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
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
