using UnityEngine;

public class BattleModeDifficultyAdjustData : ScriptableObject
{
	public float startValue;

	public AnimationCurve victoryIncreaseCurve;

	public int maxVictoryInARowCount;

	public AnimationCurve defeatIncreaseCurve;

	public int maxDefeatInARowCount;
}
