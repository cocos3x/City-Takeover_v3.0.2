using System;
using System.Collections.Generic;

public class TimedRewardsManager
{
	private class Reward
	{
		public string Name;

		public bool Owns;

		public DateTime LastClaimed;

		public TimeSpan Interval;
	}

	private static Dictionary<TimedRewardType, Reward> rewards;

	private static string lastClaimed;

	private static string owned;

	public static void Init()
	{
	}

	public static bool Owns(TimedRewardType rewardType)
	{
		return false;
	}

	public static bool CanClaim(TimedRewardType rewardType)
	{
		return false;
	}

	public static TimeSpan TimeUntilNextClaim(TimedRewardType rewardType)
	{
		return (TimeSpan)null;
	}

	public static void UnlockReward(TimedRewardType rewardType)
	{
	}

	public static void OnRewardClaimed(TimedRewardType rewardType)
	{
	}
}
