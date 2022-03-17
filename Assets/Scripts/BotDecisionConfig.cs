using System.Collections.Generic;
using UnityEngine;

public class BotDecisionConfig : ScriptableObject
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public BuildingType _Type;

		internal bool _003CGetBuildingTypeDecisionValue_003Eb__0(BuildingTypeDecisionValue buildingType)
		{
			return false;
		}
	}

	public List<BuildingTypeDecisionValue> buildingTypeDecisionValues;

	public AnimationCurve enemiesScoreValueCurve;

	public AnimationCurve friendlyScoreValueCurve;

	public float conquerBuildingFactor;

	public float defendBuildingFactor;

	public float decisionValueFactor;

	private float maxDecisionValue;

	public float GetBuildingTypeDecisionValue(BuildingType _Type)
	{
		return 0f;
	}

	public float GetBuildingScoreValue(float _NormalizedValue, bool _Friendly)
	{
		return 0f;
	}

	public void SetDecisionValue(float _Value)
	{
	}
}
