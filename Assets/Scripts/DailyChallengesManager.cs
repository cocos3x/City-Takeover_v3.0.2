using System;
using VoodooPackages.Tech;

public class DailyChallengesManager : SingletonMB<DailyChallengesManager>
{
	public LevelJsonCategory Levels;

	private bool _003CCompleted_003Ek__BackingField;

	private int _003CLastDayPlayed_003Ek__BackingField;

	private int _003CHeartsLeft_003Ek__BackingField;

	private (string, string) _003CReward_003Ek__BackingField;

	private string _003CBossHead_003Ek__BackingField;

	private string _003CBossSword_003Ek__BackingField;

	private string _003CBossShield_003Ek__BackingField;

	public bool Completed
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public int LastDayPlayed
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int HeartsLeft
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public (string, string) Reward
	{
		get
		{
			return ((string, string))null;
		}
		private set
		{
		}
	}

	public string BossHead
	{
		get
		{
			return "";
		}
		private set
		{
		}
	}

	public string BossSword
	{
		get
		{
			return "";
		}
		private set
		{
		}
	}

	public string BossShield
	{
		get
		{
			return "";
		}
		private set
		{
		}
	}

	public void Init()
	{
	}

	public void InitState()
	{
	}

	public bool AttemptRefreshState()
	{
		return false;
	}

	public void ForceReset()
	{
	}

	public void SaveState()
	{
	}

	public bool HasEnoughHeartsToPlay()
	{
		return false;
	}

	public int GetTodaysNumber()
	{
		return 0;
	}

	public void UseHeart()
	{
	}

	public void ReplenishHearts()
	{
	}

	public void CompleteChallenge()
	{
	}

	public TimeSpan GetTimeLeftToTomorrow()
	{
		return (TimeSpan)null;
	}

	private void SetRandomReward()
	{
	}

	private void SetRandomBoss()
	{
	}

	public int GetMaxHearts()
	{
		return 0;
	}
}
