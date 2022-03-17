using System;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpData : ScriptableObject
{
	[Serializable]
	public class PuShopDatas
	{
		public int cost;

		public int quantityPurchased;

		public int quantityAtStart;

		public int maximumQuantity;

		public int levelRequiredToUnlock;

		public int rvShopPuQuantity;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PowerUpData, int> _003C_003E9__3_0;

		public static Func<PowerUpData, int> _003C_003E9__3_1;

		internal int _003Cget_Power_003Eb__3_0(PowerUpData pu)
		{
			return 0;
		}

		internal int _003Cget_Power_003Eb__3_1(PowerUpData pu)
		{
			return 0;
		}
	}

	private static Dictionary<string, PowerUpData> _Powers;

	public PowerUpsConfig.Type type;

	public string powerId;

	public string powerNameLocID;

	public Sprite powerIcon;

	public Target target;

	public PowerUpBase powerUp;

	[SerializeField]
	private TutorialStep tutorial;

	[SerializeField]
	private bool fullTuto;

	[SerializeField]
	private PuShopDatas defaultShopDatas;

	public PuShopDatas currentShopDatas;

	public static Dictionary<string, PowerUpData> Power => null;

	public TutorialStep Tutorial => (TutorialStep)null;

	public bool IsFullTuto => false;

	public bool CanBuy => false;

	public bool IsUnlocked
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public int Quantity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaximumQuantity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsInfinit => false;

	public int TimeLeftBeforeUse => 0;

	public static bool CheckAvailablePower(out List<PowerUpData> unlocked)
	{
		return false;
	}

	public static bool CheckUnlockedPower(out List<PowerUpData> unlocked)
	{
		return false;
	}

	private static bool StringToValue(string inner, ref PowerUpData power, out string target, out int value)
	{
		return false;
	}

	private static void SetPuShopValue(string varName, string[] varArray, ref PowerUpData powers)
	{
	}

	private static void UpdateRsPuShopDatas(ref PowerUpData[] powers)
	{
	}

	public bool CanActivateOnBuilding(Building b)
	{
		return false;
	}

	public void PlayPower(Building target)
	{
	}

	public bool BuyPower()
	{
		return false;
	}

	public void ForceTimerRefresh()
	{
	}

	public void UpdateUseTimer()
	{
	}
}
