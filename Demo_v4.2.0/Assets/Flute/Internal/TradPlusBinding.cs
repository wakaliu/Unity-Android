﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

[SuppressMessage("ReSharper", "AccessToStaticMemberViaDerivedType")]
public class TradPlusBinding
{
    public TradPlus.Reward SelectedReward;

    private readonly string _adUnitId;
    public TradPlusBinding(string adUnitId)
    {
        _adUnitId = adUnitId;
        SelectedReward = new TradPlus.Reward { Label = string.Empty };
    }

    public void CreateBanner(TradPlus.AdPosition position)
    {
        _tradplusCreateBanner((int)position, _adUnitId);
    }

    public void DestroyBanner()
    {
        _tradplusDestroyBanner(_adUnitId);
    }

    public void ShowBanner(bool shouldShow)
    {
        _tradplusShowBanner(_adUnitId, shouldShow);
    }

    public void RequestInterstitialAd()
    {
        _tradplusRequestInterstitialAd(_adUnitId);
    }

    public bool IsInterstitialReady
    {
        get { return _tradplusIsInterstitialReady(_adUnitId); }
    }

    public void ShowInterstitialAd()
    {
        _tradplusShowInterstitialAd(_adUnitId);
    }

    public void DestroyInterstitialAd()
    {
        _tradplusDestroyInterstitialAd(_adUnitId);
    }

    public void RequestRewardedVideo()
    {
        _tradplusRequestRewardedVideo(_adUnitId);
    }

    // Queries if a rewarded video ad has been loaded for the given ad unit id.
    public bool HasRewardedVideo()
    {
        return _tradplusHasRewardedVideo(_adUnitId);
    }

    // If a rewarded video ad is loaded this will take over the screen and show the ad
    public void ShowRewardedVideo()
    {
        _tradplusShowRewardedVideo(_adUnitId);
    }

    public void DestroyRewardedVideo()
    {
        _tradplusDestroyRewardedVideo(_adUnitId);
    }
    #region DllImports
#if ENABLE_IL2CPP && UNITY_ANDROID
    // IL2CPP on Android scrubs DllImports, so we need to provide stubs to unblock compilation
    private static void _tradplusCreateBanner(int position, string adUnitId) { }
    private static void _tradplusDestroyBanner(string adUnitId) {}
    private static void _tradplusShowBanner(string adUnitId, bool shouldShow) {}
    private static void _tradplusRefreshBanner(string adUnitId, string keywords, string userDataKeywords) {}
    private static void _tradplusSetAutorefreshEnabled(string adUnitId, bool enabled) {}
    private static void _tradplusForceRefresh(string adUnitId) {}
    private static void _tradplusRequestInterstitialAd(string adUnitId) {}
    private static bool _tradplusIsInterstitialReady(string adUnitId) { return false; }
    private static void _tradplusShowInterstitialAd(string adUnitId) {}
    private static void _tradplusDestroyInterstitialAd(string adUnitId) {}
    private static void _tradplusRequestRewardedVideo(string adUnitId) {}
    private static bool _tradplusHasRewardedVideo(string adUnitId) { return false; }
    private static string _tradplusGetAvailableRewards(string adUnitId) { return null; }
    private static void _tradplusShowRewardedVideo(string adUnitId) {}
    private static void _tradplusDestroyRewardedVideo(string adUnitId) {}
#else
    [DllImport("__Internal")]
    private static extern void _tradplusCreateBanner(int position, string adUnitId);


    [DllImport("__Internal")]
    private static extern void _tradplusDestroyBanner(string adUnitId);


    [DllImport("__Internal")]
    private static extern void _tradplusShowBanner(string adUnitId, bool shouldShow);

    [DllImport("__Internal")]
    private static extern void _tradplusRequestInterstitialAd(string adUnitId);


    [DllImport("__Internal")]
    private static extern bool _tradplusIsInterstitialReady(string adUnitId);


    [DllImport("__Internal")]
    private static extern void _tradplusShowInterstitialAd(string adUnitId);


    [DllImport("__Internal")]
    private static extern void _tradplusDestroyInterstitialAd(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusRequestRewardedVideo(string adUnitId);


    [DllImport("__Internal")]
    private static extern bool _tradplusHasRewardedVideo(string adUnitId);


    [DllImport("__Internal")]
    private static extern void _tradplusShowRewardedVideo(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusDestroyRewardedVideo(string adUnitId);

#endif
    #endregion
}
