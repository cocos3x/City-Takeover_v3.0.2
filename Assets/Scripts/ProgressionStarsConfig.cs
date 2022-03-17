using UnityEngine;

public class ProgressionStarsConfig
{
	public bool enabled;

	public int firstLockLevel;

	public int nbLevelsBetweenLock;

	public float maximumTimeForStar1;

	public float maximumTimeForStar2;

	public float maximumTimeForStar3;

	public int maxNbBuildingsLostForStar1;

	public int maxNbBuildingsLostForStar2;

	public int maxNbBuildingsLostForStar3;

	public int[] amountOfStarsToUnlockSection;

	public bool canDowngradeToFs;

	public bool fsAlwaysReplacesRV;

	public Vector2Int GetLevelsSectionBounds(int currentLevel)
	{
		return (Vector2Int)null;
	}

	public int GetUnlockStarsForSection(int sectionlevel)
	{
		return 0;
	}
}
