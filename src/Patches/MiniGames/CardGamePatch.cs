using System.Collections.Generic;
using System.Reflection.Emit;
using HarmonyLib;
using RPCPlugin.RPCController;
using RPCPlugin.Utils;
namespace RPCPlugin.Patches.MiniGames
{
    [HarmonyPatch(typeof(CardGame))]
    class CardGamePatches
    {
        [HarmonyPostfix]
        [HarmonyPatch("BuildWindow")]
        private static void BuildWindow(int ___windowid)
        {
            if (___windowid == 10)
            {
                PluginUtils.SetOverworldActivity();
            }
        }
        [HarmonyTranspiler]
        [HarmonyPatch("PullCard", MethodType.Enumerator)]
        private static IEnumerable<CodeInstruction> PullCardPatch(IEnumerable<CodeInstruction> instructions)
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
        }
    }
}
