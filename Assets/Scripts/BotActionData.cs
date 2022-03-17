using UnityEngine;

public class BotActionData : ScriptableObject
{
	[SerializeField]
	private BotActionConfig _botActionConfig;

	public BotActionConfig BotActionConfig => null;

	public float GetBattleOffset(float _BattleValue)
	{
		return 0f;
	}
}
