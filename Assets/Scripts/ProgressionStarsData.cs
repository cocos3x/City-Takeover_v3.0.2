using System;
using System.Collections.Generic;

[Serializable]
public class ProgressionStarsData
{
	private const string PROGRESSION_STARS_DATA_KEY = "WorldMapManager.ProgressionStarsData";

	public int lastUnlockedLevel;

	public int currentSectionStartLevel;

	public List<int> nbStarsForLevel;

	public int GetStarsForLevel(int level)
	{
		return 0;
	}

	public void SetStarsForLevel(int level, int nbStars)
	{
	}

	public int StarsAmountForSection(int currentLevel)
	{
		return 0;
	}

	public static ProgressionStarsData Load()
	{
		return null;
	}

	public void Save()
	{
	}

	public void AdjustWithLevelProgressIfNeeded(int levelProgress)
	{
	}
}
