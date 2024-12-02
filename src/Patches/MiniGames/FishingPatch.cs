using System.Collections;
using HarmonyLib;
using RPCPlugin.RPCController;
using RPCPlugin.Utils;
using UnityEngine;

namespace RPCPlugin.Patches.MiniGames
{
    [HarmonyPatch(typeof(FishingMain))]
    public class FishingPatch
    {
        [HarmonyPatch("Start"), HarmonyPostfix]
        private static void Start()
        {
            Controller.UpdateData("Playing: Fishing", "Depth: 0.00cm | Combo: 0", "fishing");
            Controller.Instance.StartCoroutine(FishingLoop());
        }
        private static IEnumerator FishingLoop()
        {
            while (FishingMain.instance)
            { 
                Controller.UpdateData("Playing: Fishing", $"{FishingMain.instance.GetDepth()} | Combo: {FishingMain.instance.combo}", "fishing");
                yield return new WaitForSeconds(1f);
            }
            PluginUtils.SetOverworldActivity();
        }
    }
}
