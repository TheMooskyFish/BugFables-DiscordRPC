using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace RPCPlugin
{
    [BepInPlugin("dev.mooskyfish.discordrpc", "Discord RPC", "1.1.1")]
    [BepInProcess("Bug Fables.exe")]
    internal class RPCPlugin : BaseUnityPlugin
    {
#if RPCDEBUG
        public static readonly string Version = MetadataHelper.GetMetadata(typeof(RPCPlugin)).Version.ToString() + "-DEV";
#else
        public static readonly string Version = MetadataHelper.GetMetadata(typeof(RPCPlugin)).Version.ToString() + "";
#endif
        public new static ManualLogSource Logger;
        public void Awake()
        {
            Logger = base.Logger;
            var harmony = new Harmony("dev.mooskyfish.discordrpc");
            harmony.PatchAll();
        }
    }
}
