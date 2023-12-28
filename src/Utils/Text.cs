#if RPCDEBUG
using UnityEngine;
using HarmonyLib;
namespace RPCPlugin
{
    public class Text
    {
        public static DynamicFont CurrentMap;

        public static void CreateText()
        {
            if (CurrentMap == null)
                CurrentMap = DynamicFont.SetUp(true, 1, 2, 100, new Vector2(0.5f, 0.5f), MainManager.GUICamera.transform, new Vector3(-8.8925f, -5.0355f, 10f));
            CurrentMap.name = "RPCText";
        }
        public static void ChangeData(string details, string state, string rawMap)
        {
            if (CurrentMap)
                CurrentMap.text = $"{details} - {rawMap}\n{state}";

        }
        [HarmonyPatch(typeof(MainManager), "SetVariables")]
        public class SetVariablesPatch
        {
            static void Postfix()
            {
                if (!CurrentMap)
                {
                    CreateText();
                }
            }
        }
    }
}
#endif