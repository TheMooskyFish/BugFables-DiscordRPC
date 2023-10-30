using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using HarmonyLib;
using RPCPlugin.RPCController;
using RPCPlugin.Utils;
using UnityEngine;
namespace RPCPlugin.Patches
{
    class MiniGamesPatches
    {
        [HarmonyPatch(typeof(CardGame))]
        private class CardGamePatch
        {
            [HarmonyPostfix]
            [HarmonyPatch("BuildWindow")] //, int[] ___hp, int[] ___tp, Transform[,] ___huds
            private static void BuildWindow(CardGame __instance, int ___windowid)
            {
                if (___windowid == 10)
                {
                    __instance.StopCoroutine("CardGameScoreLoop");
                    PluginUtils.SetOverworldActivity();

                }
                //else if (___windowid == 1)
                //{
                //    if (___huds != null)
                //        Controller.UpdateData($"Playing: Spy Cards", $"HP: {___hp[0]} | TP: {___tp[0]}", "spycards");
                //}
                //RPCPlugin.Logger.LogInfo(___windowid);
            }
            [HarmonyTranspiler]
            [HarmonyPatch("PullCard", MethodType.Enumerator)]
            static IEnumerable<CodeInstruction> PullCardPatch(IEnumerable<CodeInstruction> instructions)
            {
                return new CodeMatcher(instructions)
                .MatchForward(true,
                    new CodeMatch(OpCodes.Ldc_I4_S),
                    new CodeMatch(OpCodes.Call),
                    new CodeMatch(OpCodes.Stelem_I4),
                    new CodeMatch(OpCodes.Stfld)
                ).Advance(1).InsertAndAdvance(new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(PluginUtils), nameof(PluginUtils.UpdateCardRPC)))).InstructionEnumeration();
            }
            [HarmonyPrefix]
            [HarmonyPatch("StartCard")]
            private static void StartCard()
            {
                Controller.UpdateData($"Playing: Spy Cards", "HP: 5 | Round: 1", "spycards");
                //__instance.StartCoroutine(CardGameScoreLoop(__instance));
            }
        }
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
            private static void OnTriggerEnter()
            {
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

        private static IEnumerator ScoreLoop(Component miniGame, string name)
        {
            var score = AccessTools.Field(miniGame.GetType(), "score");
            var oldScore = 0;
            var miniGameName = miniGame.GetType().Name.ToLower();
            while (true)
            {
                if (oldScore != (int)score.GetValue(miniGame))
                {
                    var newScore = (int)score.GetValue(miniGame);
                    Controller.UpdateData($"Playing: {name}", $"Score: {newScore}", miniGameName);
                    oldScore = newScore;
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