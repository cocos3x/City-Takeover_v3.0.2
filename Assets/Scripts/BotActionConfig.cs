using System;
using UnityEngine;

[Serializable]
public class BotActionConfig
{
	public Vector2 decisionMakingTimeRange;

	public Vector2 startDecisionMakingTimeRange;

	public int maxDecisionCapacity;

	public AnimationCurve reflexionPowerCurve;

	public float maxAIValue;
}
