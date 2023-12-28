using RPCPlugin.RPCController;
using RPCPlugin.Maps;
namespace RPCPlugin.Utils
{
    public class PluginUtils
    {
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
            Controller.UpdateData($"Playing: Spy Cards", $"HP: {cardGame.hp[0]} | Round: {MainManager.instance.flagvar[6]}", "spycards");
        }
    }
}