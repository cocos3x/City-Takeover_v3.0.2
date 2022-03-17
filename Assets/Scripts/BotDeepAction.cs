using UnityEngine;

public class BotDeepAction : BotAction
{
	private AnimationCurve _reflexionPowerCurve;

	private float _maxIAValue;

	private float _maxDecisionValue;

	public override void Init(BotActionConfig _ActionConfig)
	{
	}

	protected override void PickDecision()
	{
	}

	private float AddSurroundingFactor(Building _FromBuilding, Building _ToBuilding, BotDecisionConfig _Config)
	{
		return 0f;
	}
}
