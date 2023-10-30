using RPCPlugin.RPCController;
using RPCPlugin.Maps;
using HarmonyLib;
namespace RPCPlugin.Utils
{
    public class PluginUtils
    {
        //public static void SetMapAndImageActivity(int id)
        //{
        //    SetOverworldActivity(MapsClass.Maps[id], MainManager.instance.partylevel);
        //}
        public static void SetOverworldActivity()
        {
            SetOverworldActivity(GetCurrentMap(), MainManager.instance.partylevel);
        }
        public static void SetOverworldActivity(string area, int rank)
        {
            var image = MapsClass.GetMapImage(int.Parse(MainManager.map.name));
            Controller.UpdateData($"Area: {area}", $"Rank: {rank}", image);
        }
        public static string GetCurrentMap()
        {
            return MapsClass.Maps[int.Parse(MainManager.map.name)];
        }
        public static void UpdateCardRPC()
        {
            var cardGame = MainManager.instance.GetComponent<CardGame>();
            var hp = Traverse.Create(cardGame).Field("hp").GetValue<int[]>()[0];
            Controller.UpdateData($"Playing: Spy Cards", $"HP: {hp} | Round: {MainManager.instance.flagvar[6]}", "spycards");
        }
    }
}