using System.Collections.Generic;

public class PowerUpsConfig
{
	public enum Type
	{
		UNKNOWN,
		METEOR,
		GROW,
		FREEZE,
		SHIELD
	}

	public bool IsEnabled;

	public bool UseClickInsteadOfDragDrop;

	public bool MeteorActive;

	public int MeteorUnlockAtLevel;

	public List<float> MeteorRefreshTimeSeconds;

	public int MeteorDamage;

	public bool GrowBoostActive;

	public int GrowBoostUnlockAtLevel;

	public List<float> GrowBoostRefreshTimeSeconds;

	public int GrowScoreToAdd;

	public bool FreezeActive;

	public int FreezeUnlockAtLevel;

	public List<float> FreezeRefreshTimeSeconds;

	public int FreezeDuration;

	public bool ShieldActive;

	public int ShieldUnlockAtLevel;

	public List<float> ShieldRefreshTimeSeconds;

	public int ShieldDuration;

	public string NotificationTitle;

	public string NotificationDescription;

	public bool IsActive(Type type)
	{
		return false;
	}

	public bool IsUnlocked(Type type, int currentLevel)
	{
		return false;
	}

	public int GetUnlockLevel(Type type)
	{
		return 0;
	}

	public int RefreshTimeInSeconds(Type type, int numberPreviousUse)
	{
		return 0;
	}
}
