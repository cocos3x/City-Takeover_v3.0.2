using UnityEngine;

public class BattleModeData : ScriptableObject
{
	[SerializeField]
	private int _unlockedLevel;

	[SerializeField]
	private BattleModeDifficultyAdjustData _battleModeDifficultyAdjustData;

	[SerializeField]
	private BattleModePlayerColorData _battleModePlayerColorData;

	[SerializeField]
	private BattleModeMedalData _battleModeMedalData;

	public int UnlockedLevel => 0;

	public BattleModeDifficultyAdjustData BattleModeDifficultyAdjustData => null;

	public BattleModePlayerColorData BattleModePlayerColorData => null;

	public BattleModeMedalData BattleModeMedalData => null;
}
