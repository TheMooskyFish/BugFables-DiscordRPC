using UnityEngine;
using Discord;
using System;
using System.Collections;
namespace RPCPlugin.RPCController;
public class Controller : MonoBehaviour
{
    private static double s_time = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    private static Discord.Discord s_discordClient;
    public static Controller Instance;
    private static bool s_discordOffine;
    public void Start()
    {
        DontDestroyOnLoad(this);
        Instance = this;
        s_time = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        try
        {
            s_discordClient = new Discord.Discord(1152749295603302471, (ulong)CreateFlags.NoRequireDiscord);
            RPCPlugin.Logger.LogInfo("Discord is running.");
        }
        catch (Exception)
        {
            RPCPlugin.Logger.LogError("Discord is not running.");
            s_discordOffine = true;
            StartCoroutine(DiscordTimer());
            return;
        }
        UpdateData("Main Menu");
    }
    private bool ReloadDiscord()
    {
        try
        {
            s_discordClient?.Dispose();
            s_discordClient = new Discord.Discord(1152749295603302471, (ulong)CreateFlags.NoRequireDiscord);
            s_discordOffine = false;
            UpdateData("");
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public void LateUpdate()
    {
        try
        {
            if (!s_discordOffine)
            {
                s_discordClient.RunCallbacks();
            }
        }
        catch (ResultException)
        {
            RPCPlugin.Logger.LogError("Discord no longer running.");
            s_discordClient?.Dispose();
            s_discordClient = null;
            s_discordOffine = true;
            StartCoroutine(DiscordTimer());
        }
    }
    public void OnApplicationQuit()
    {
        RPCPlugin.Logger.LogInfo("Unloading Discord RPC.");
        s_discordClient?.Dispose();
    }
    private IEnumerator DiscordTimer()
    {
        while (s_discordOffine)
        {
            var status = Instance.ReloadDiscord();
            if (status)
            {
                yield break;
            }
            else
            {
                yield return new WaitForSeconds(5);
            }
        }
    }
    public static void UpdateData(string details) => UpdateData(new Activity { Details = details });
    public static void UpdateData(string details, string state, string image = "icon") => UpdateData(new Activity { Details = details, State = state, Assets = new ActivityAssets { LargeImage = image } });

    private static void UpdateData(Activity activity)
    {
        if (!s_discordOffine)
        {
            try
            {
                activity.Assets.LargeImage ??= "icon";
                activity.Assets.LargeText = $"Mod: {RPCPlugin.Version} Game: {Application.version}";
                activity.Timestamps.Start = (long)s_time;
                s_discordClient.GetActivityManager().UpdateActivity(activity, (_) => { });
            }
            catch (Exception error)
            {
                RPCPlugin.Logger.LogError(error);
            };
        }
    }
}
