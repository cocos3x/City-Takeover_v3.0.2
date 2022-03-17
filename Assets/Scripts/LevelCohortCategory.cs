using UnityEngine;

public class LevelCohortCategory : ScriptableObject
{
	[SerializeField]
	private LevelJsonCategory controlLevelCategory;

	[SerializeField]
	private LevelJsonCategory newProgressionLevelCategory;

	[SerializeField]
	private LevelJsonCategory newProgression2LevelCategory;

	[SerializeField]
	private LevelJsonCategory newLevels100;

	[SerializeField]
	private LevelJsonCategory smallOnBoardingCategory;

	[SerializeField]
	private LevelJsonCategory longOnBoardingCategory;

	[SerializeField]
	private LevelJsonCategory multiplayerMorePlayerCategory;

	[SerializeField]
	private LevelJsonCategory smallOnBoardingAndNewProgressionLevelCategory;

	[SerializeField]
	private LevelJsonCategory smallOnBoardingAndNewProgression2LevelCategory;

	[SerializeField]
	private LevelJsonCategory longOnBoardingAndNewProgressionLevelCategory;

	[SerializeField]
	private LevelJsonCategory longOnBoardingAndNewProgression2LevelCategory;

	[SerializeField]
	private LevelJsonCategory new100LevelsCategory;

	public LevelJsonCategory GetCurrentLevelJsonCategory()
	{
		return null;
	}
}
