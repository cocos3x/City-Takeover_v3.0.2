using System.Collections.Generic;
using UnityEngine;
using VoodooPackages.Tech;

public class BotManager : SingletonMB<BotManager>
{
	[SerializeField]
	private BotDecisionConfig _botDecisionConfig;

	[SerializeField]
	private List<BotActionData> _botActionDatas;

	private GameManager _gameManager;

	private BattleModeManager _battleModeManager;

	public BotDecisionConfig CurrentDecisionConfig => null;

	private void Awake()
	{
	}

	public BotActionConfig GetSetuppedActionConfig()
	{
		return null;
	}
}
