using UnityEngine;

public class GameUi : MonoBehaviour
{
	public delegate void d_OnInputDown();

	public delegate void d_OnInputUp();

	[SerializeField]
	private UiScreenDatas _screenDatas;

	[SerializeField]
	private RectTransform canvasRect;

	private Camera _003Ccam_003Ek__BackingField;

	public Transform screensParent;

	private MainMenuUi _mainMenuUi;

	private HudUi _hudUi;

	private CampaignModeLevelCompleteUi _campaignModeLevelCompleteUi;

	private BattleModeLevelCompleteUi _battleModeLevelCompleteUi;

	private GameOverUi _gameOverUi;

	private BattleModeGameOverUi _battleModeGameOverUi;

	private TutorialUi _tutorialUi;

	private ShopUi _shopUi;

	private CoinContainerUi _coinContainerUi;

	private CoinContainerUi _crownContainerUi;

	private CustomizationUi _customizationUi;

	private SettingsUi _settingsUi;

	private PowerShopUi _powerShopUi;

	private DailyChallengeUi _dailyChallengeUi;

	private DebugScreenUi _debugUi;

	private PowerUpTutorialView _powerUpTutorialView;

	private SearchOpponentView _searchOpponentView;

	private BattleModeTutorialUi _battleModeTutorialUi;

	private MapUi _mapUi;

	private LightSkinShopUi _lightSkinShopUi;

	public d_OnInputDown OnInputDown;

	public d_OnInputUp OnInputUp;

	public Camera cam
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MainMenuUi mainMenuUi => null;

	public HudUi hudUi => null;

	public CampaignModeLevelCompleteUi CampaignModeLevelCompleteUi => null;

	public BattleModeLevelCompleteUi BattleModeLevelCompleteUi => null;

	public GameOverUi gameOverUi => null;

	public BattleModeGameOverUi BattleModeGameOverUi => null;

	public TutorialUi tutorialUi => null;

	public ShopUi shopUi => null;

	public CoinContainerUi coinContainerUi => null;

	public CoinContainerUi crownContainerUi => null;

	public CustomizationUi customizationUi => null;

	public SettingsUi settingsUi => null;

	public PowerShopUi powerShopUi => null;

	public DailyChallengeUi dailyChallengeUi => null;

	public DebugScreenUi debugUi => null;

	public PowerUpTutorialView powerUpTutorialView => null;

	public SearchOpponentView searchOpponentView => null;

	public BattleModeTutorialUi BattleModeTutorialUi => null;

	public MapUi mapUi => null;

	public LightSkinShopUi lightSkinShopUi => null;

	public void Start()
	{
	}

	public Vector2 WorldToCanvas(Vector3 worldPosition)
	{
		return (Vector2)null;
	}

	private T GetOrCreateScreen<T>(ref T screen)
	{
		return (T)null;
	}

	public void _OnInputDown()
	{
	}

	public void _OnInputUp()
	{
	}

	private void _003CStart_003Eb__67_0()
	{
	}
}
