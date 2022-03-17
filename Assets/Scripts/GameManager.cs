using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private sealed class _003CIDelayPlayPressed_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CIDelayPlayPressed_003Ed__96(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static readonly int BONUS_LEVEL_STEP;

	private const float _NORMAL_GAME_SPEED = 1f;

	private static float _003CGameSpeed_003Ek__BackingField;

	private int _003CLevelProgress_003Ek__BackingField;

	private int _003CCoins_003Ek__BackingField;

	private int _003CCrowns_003Ek__BackingField;

	private int _003CHighestLevelProgress_003Ek__BackingField;

	private int _003CLevelsUntilBonusLevel_003Ek__BackingField;

	public GameUi gameUi;

	public CustomizationManager customizationManager;

	public DailyChallengesManager dailyChallengesManager;

	public IncrementalController incrementalController;

	private bool shouldStartGameWithPowerup;

	public ProgressionStarsData progressionStars;

	private CameraSettings lastCameraSettings;

	[SerializeField]
	private LevelCohortCategory _levelCohortCategory;

	private LevelJsonCategory _levelJsonCategory;

	public static bool s_HasRestart;

	public static bool s_HasRetry;

	private EGameMode _gameMode;

	private string _currentLevelData;

	private LevelDescription _currentLevelDescription;

	private static GameManager instance;

	public int _totalLevels;

	private int _tutorialLevels;

	public static float GameSpeed
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public int LevelProgress
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int Coins
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int Crowns
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int HighestLevelProgress
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int LevelsUntilBonusLevel
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public bool ShouldStartGameWithPowerup => false;

	public int OnboardingLevelCount => 0;

	public bool OnboardingEnded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool AbOnboarding => false;

	public LevelJsonCategory LevelJsonCategory => null;

	public EGameMode GameMode => (EGameMode)null;

	public string CurrentLevelData => "";

	public LevelDescription CurrentLevelDescription => null;

	public static GameManager Instance => null;

	public int CurrentWinStreak
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public static event Action<EGameMode> EventOnLevelComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<EGameMode> EventOnLevelSkipped
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<EGameMode> EventOnLevelFail
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<EGameMode> EventOnGameModeChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public bool IsOnboarding(int level)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void SetLevelProgress(int levelProgress)
	{
	}

	public int IncrementLevelProgress()
	{
		return 0;
	}

	public bool CanAffordWithCoins(int amount)
	{
		return false;
	}

	public void ChangeCoinBalance(int delta)
	{
	}

	public bool CanAffordWithCrowns(int amount)
	{
		return false;
	}

	public void ChangeCrownsBalance(int delta)
	{
	}

	private void Init()
	{
	}

	public void ChangeGameMode(EGameMode _GameMode)
	{
	}

	private bool LoadLevel(int levelNumber)
	{
		return false;
	}

	public void OnLevelLoaded(LevelManager level)
	{
	}

	public void OnLevelCompleted()
	{
	}

	public void OnLevelSkipped()
	{
	}

	public void AttemptAppReview()
	{
	}

	public void OnLevelFailed()
	{
	}

	public void OnStartButtonPressed()
	{
	}

	public void LoadCurrentLevelDelay()
	{
	}

	public void OnBattleModeSearchFinished()
	{
	}

	public void OnStartWithPowerUpButtonPressed()
	{
	}

	public void LoadMatch(EGameMode mode)
	{
	}

	private void DelayPlayPressed()
	{
	}

	private IEnumerator IDelayPlayPressed()
	{
		return null;
	}

	public void OnContinueButtonPressed()
	{
	}

	public void ShowMainMenuUI(bool show, bool fade = false, float fadingDuration = 0.2f)
	{
	}

	public void OnMenuButtonPressed()
	{
	}

	public void OnRestartPressed()
	{
	}

	public void CalculateTotalLevels()
	{
	}

	private void LoadCurrentLevel()
	{
	}

	private void GenerateLevelDescription()
	{
	}

	public void OnRevenge()
	{
	}

	private void LoadJSONLevelScene()
	{
	}

	private void LoadScene()
	{
	}

	public CameraSettings SetLastCameraSettings(Camera cam)
	{
		return (CameraSettings)null;
	}

	public CameraSettings GetLastCameraSettings(Camera currentCam)
	{
		return (CameraSettings)null;
	}

	public bool IsTutorial()
	{
		return false;
	}

	public bool WasTutorial()
	{
		return false;
	}

	public string GetLevelLaunchType()
	{
		return "";
	}

	public static void DEBUG_GIVE_COINS(int coinAmount)
	{
	}

	public static void DEBUG_GIVE_CROWNS(int amount)
	{
	}

	public static void DEBUG_SET_LEVEL(int level, bool playAudio = true)
	{
	}

	public static void DEBUG_SET_STARS(int stars)
	{
	}

	private void OnDestroy()
	{
	}

	public void SetNormalSpeed()
	{
	}

	public bool IsNormalSpeed()
	{
		return false;
	}

	public void SetSpecialSpeed(float speed)
	{
	}

	public float GetWinStreakGoldMultiplier(int winCount)
	{
		return 0f;
	}

	public float CurrentWinStreakGoldMultiplier()
	{
		return 0f;
	}

	public int GetWinStreakFloorBoost(int winCount)
	{
		return 0;
	}

	public int CurrentWinStreakFloorBoost()
	{
		return 0;
	}

	private void IncrementWinStreak()
	{
	}

	public void ResetWinStreak()
	{
	}

	private void _003COnStartButtonPressed_003Eb__90_0()
	{
	}
}
