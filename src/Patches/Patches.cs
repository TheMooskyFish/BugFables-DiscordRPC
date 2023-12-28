using HarmonyLib;
using RPCPlugin.RPCController;
using RPCPlugin.Maps;
using RPCPlugin.Utils;
using UnityEngine;
using System;
namespace RPCPlugin.Patches
{
    class PluginPatches
    {
        [HarmonyPatch(typeof(MainManager), nameof(MainManager.LoadMap), new Type[] { typeof(int) })]
        class LoadMapPatch
        {
            static void Postfix(int id)
            {
                PluginUtils.SetOverworldActivity(MapsClass.Maps[id], MainManager.instance.partylevel);
#if RPCDEBUG
                Text.ChangeData($"Area: {MapsClass.Maps[id]}", $"Rank: {MainManager.instance.partylevel}", Enum.GetName(typeof(MainManager.Maps), id));
#endif
            }
        }
        [HarmonyPatch(typeof(MainManager), "Start")]
        class StartMainPatch
        {
            static void Postfix()
            {
                if (!GameObject.Find("RPCController"))
                {
                    new GameObject("RPCController").AddComponent<Controller>();
                }
                else
                {
                    Controller.UpdateData("Main Menu");
                }
            }
        }
        [HarmonyPatch(typeof(BattleControl), nameof(BattleControl.StartBattle))]
        class BattleControlPatch
        {
            [HarmonyPostfix]
            static void StartBattlePatch()
            {
                var map = MapsClass.Maps[int.Parse(MainManager.map.name)];
                Controller.UpdateData($"In Battle: {map}", $"Rank: {MainManager.instance.partylevel}", MapsClass.GetMapImage(int.Parse(MainManager.map.name)));
            }
            [HarmonyPatch(nameof(BattleControl.ReturnToOverworld))]
            [HarmonyPostfix]
            static void ReturnToOverworldPatch()
            {
                PluginUtils.SetOverworldActivity();
            }
        }
    }
}