using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelJsonCategory : ScriptableObject
{
	[SerializeField]
	protected int _onBoardingLevelCount;

	[SerializeField]
	protected List<TextAsset> _levelDatas;

	[SerializeField]
	private List<TextAsset> _battleModeLevelDatas;

	[SerializeField]
	protected TextAsset debugLevel;

	[NonSerialized]
	private List<TextAsset> _levelDatasReorder;

	private List<TextAsset> LevelDatasReorder => null;

	private List<TextAsset> GetOrderRs()
	{
		return null;
	}

	private void StringToValue(string inner, out int toReplace, out int by)
	{
	}

	public TextAsset GetLevelDataByLevelIndex(int _LevelIndex)
	{
		return null;
	}

	public virtual TextAsset GetCurrentLevelData()
	{
		return null;
	}

	public TextAsset GetBattleModeLevel()
	{
		return null;
	}

	public int GetLevelCount()
	{
		return 0;
	}
}
