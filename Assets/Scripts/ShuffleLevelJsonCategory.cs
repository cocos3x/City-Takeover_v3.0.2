using System.Collections.Generic;
using UnityEngine;

public class ShuffleLevelJsonCategory : LevelJsonCategory
{
	[SerializeField]
	private List<TextAsset> _shuffleLevelDatas;

	private List<TextAsset> _currentShuffleLevelDatas;

	private void OnEnable()
	{
	}

	public override TextAsset GetCurrentLevelData()
	{
		return null;
	}
}
