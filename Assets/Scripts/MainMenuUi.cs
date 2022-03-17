using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUi : BaseScreenUi
{
	[SerializeField]
	private TMP_Text levelText;

	[SerializeField]
	private CanvasGroup regionButton;

	[SerializeField]
	private GameObject regionButtonShadow;

	[SerializeField]
	private TMP_Text newRegionCostText;

	[SerializeField]
	private GameObject startButton;

	[SerializeField]
	private CampaignStartButton startPowerButton;

	[SerializeField]
	private RegionProgressUi regionProgress;

	[SerializeField]
	private BattleModeView _battleModeView;

	[SerializeField]
	private Image logo;

	[SerializeField]
	private CanvasGroup content;

	[SerializeField]
	private GameObject dailyChallengeButton;

	[SerializeField]
	private PeepUi dailyChallengePip;

	[SerializeField]
	private GameObject dailyChallengeLockButton;

	[SerializeField]
	private GameObject dailyReward;

	[SerializeField]
	private GameObject mapButton;

	private const string DAILY_REWARD_LASTCOLLECT = "DAILY_REWARD_LASTCOLLECT";

	private GameManager gameManager;

	private RegionsManager regionManager;

	private void Awake()
	{
	}

	public override void OnOpen()
	{
	}

	public override void OnClose()
	{
	}

	public void FadeLogo(bool on, float duration)
	{
	}

	public void FadeContent(bool on, float duration)
	{
	}

	private void Refresh()
	{
	}

	private void OnGameModeChanged(EGameMode _GameMode)
	{
	}

	public void _OnSettingsPressed()
	{
	}

	public void _OnNewRegionClicked()
	{
	}

	public void _OnCustomizationClicked()
	{
	}

	public void _OnDailyRewardClicked()
	{
	}

	public void _OnPlayButtonPressed()
	{
	}

	public void _OnStartWithPowerPressed()
	{
	}

	public void _OnShopPressed()
	{
	}

	public void _OnDailyChallengeButtonpressed()
	{
	}

	public void OnMapPressed()
	{
	}

	private void RefreshRegionButton()
	{
	}

	public void _OnABTestDebugPressed()
	{
	}

	public void _OnGameDebugPressed()
	{
	}

	private void OnDestroy()
	{
	}
}
