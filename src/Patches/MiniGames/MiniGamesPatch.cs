using System.Collections;
using HarmonyLib;
using RPCPlugin.RPCController;
using RPCPlugin.Utils;
using UnityEngine;
namespace RPCPlugin.Patches.MiniGames
{
    internal class MiniGamesPatch
    {
        [HarmonyPatch(typeof(FlappyBee))]
        private class FlappyBeePatch
        {
            [HarmonyPrefix]
            [HarmonyPatch("Start")]
            private static void Start(FlappyBee __instance)
            {
                __instance.StartCoroutine(ScoreLoop(__instance, "Flower Journey"));
                Controller.UpdateData("Playing: Flower Journey", "Score: 0", "flappybee");
            }
        }
        [HarmonyPatch(typeof(MazeGame))]
        private class MazeGamePatch
        {
            [HarmonyPrefix]
            [HarmonyPatch("Start")]
            private static void Start(MazeGame __instance)
            {
                __instance.StartCoroutine(ScoreLoop(__instance, "Mite Knight"));
                Controller.UpdateData("Playing: Mite Knight", "Score: 0", "mazegame");
            }
        }
        [HarmonyPatch(typeof(WackaWorm))]
        private class WhackAWormPatch
        {
            [HarmonyPostfix]
            [HarmonyPatch("StartUp")]
            private static void Start()
            {
                Controller.UpdateData("Playing: Whack-a-Worm", "Score: 0", "whackaworm");
            }
            [HarmonyPostfix]
            [HarmonyPatch("OnTriggerEnter")]
            private static void OnTriggerEnter(WackaWorm __instance, Collider other)
            {
                if (!__instance.main && MainManager.player != null && MainManager.player.beemerang != null && other.transform == MainManager.player.beemerang.transform)
                    Controller.UpdateData($"Playing: Whack-a-Worm", $"Score: {MainManager.instance.flagvar[1]}", "whackaworm");
            }
        }
        [HarmonyPatch(typeof(MainManager), nameof(MainManager.EndMiniGame))]
        private class EndMiniGame
        {
            private static void Postfix()
            {
                Controller.Instance.StartCoroutine(Cleanup());
            }
        }
        private static IEnumerator ScoreLoop(Component minigame, string name)
        {
            var score = AccessTools.Field(minigame.GetType(), "score");
            var oldscore = 0;
            var minigamename = minigame.GetType().Name.ToLower();
            while (true)
            {
                if (oldscore != (int)score.GetValue(minigame))
                {
                    var newscore = (int)score.GetValue(minigame);
                    Controller.UpdateData($"Playing: {name}", $"Score: {newscore}", minigamename);
                    oldscore = newscore;
                }
                yield return new WaitForSeconds(0.5f);
            }
        }
        private static IEnumerator Cleanup()
        {
            yield return new WaitForSeconds(2);
            PluginUtils.SetOverworldActivity();
        }
    }
}
