using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.UI;
public class ReklamDuzenleyici : MonoBehaviour
{
	private RewardedAd rewardedAd;

	[SerializeField] Text txt;
	private void Start()
	{
		string adUnitId = "ca-app-pub-5898617607393376/7415114148";
		this.rewardedAd = new RewardedAd(adUnitId);
		MobileAds.Initialize(initStatus => { });
	}

	public void ButonaBasinca()
	{
		AdRequest request = new AdRequest.Builder().Build();
		this.rewardedAd.LoadAd(request);

		//events
		this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
		this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
		this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;
	}

	private void ShowRewardAd()
	{
		if (this.rewardedAd.IsLoaded())
		{
			this.rewardedAd.Show();
		}
	}
	public void CreateAndLoadRewardedAd()
	{
		string adUnitId = "ca-app-pub-5898617607393376/7415114148";
		this.rewardedAd = new RewardedAd(adUnitId);

		AdRequest request = new AdRequest.Builder().Build();
		this.rewardedAd.LoadAd(request);
	}

	//events
	public void HandleRewardedAdLoaded(object sender, EventArgs args)
	{
		ShowRewardAd();
		txt.text = "Ad is loaded!";
	}


	public void HandleRewardedAdClosed(object sender, EventArgs args)
	{
		this.CreateAndLoadRewardedAd();
		Destroy(this);
	}

	public void HandleUserEarnedReward(object sender, Reward args)
	{
		int rewardCoin = UnityEngine.Random.Range(2, 6);
		GameControl.coinCounter = PlayerPrefs.GetInt("CoinNumber") + rewardCoin;
		PlayerPrefs.SetInt("CoinNumber", GameControl.coinCounter);
		txt.text = "You gained " + rewardCoin.ToString() + " coin!";
	}
}
