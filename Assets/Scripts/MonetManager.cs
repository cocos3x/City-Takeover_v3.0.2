using UnityEngine;

public class MonetManager : ScriptableObject
{
	private static MonetManager instance;

	private WinRewardDatas winRewardDatas;

	private SkinPricesDatas skinsPricesDatas;

	private PowerUpShopDatas powerUpShopDatas;

	private LevelOrderRs levelOrderRs;

	public SkinPricesDatas SkinsPrices => null;

	public PowerUpShopDatas PowerUpShopDatas => null;

	public LevelOrderRs LevelOrderRs => null;

	public int GetWindReward => 0;

	public int GetBattleModeReward => 0;

	public static MonetManager Instance => null;

	private void UpdateDatas()
	{
	}
}
