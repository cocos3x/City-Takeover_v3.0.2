using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using VoodooPackages.Tech;

public class LevelManager : SingletonMB<LevelManager>
{
	private sealed class _003CIDelayedInit_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

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
		public _003CIDelayedInit_003Ed__86(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public TutorialStep tutorialToShow;

		public LevelManager _003C_003E4__this;

		internal void _003CAddBuilding_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public BuildingTeam oldTeam;

		internal bool _003COnBuildingCaptured_003Eb__0(Building bd)
		{
			return false;
		}
	}

	private sealed class _003CIWaitToCollectAllCrowns_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

		private float _003CtimeLeft_003E5__2;

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
		public _003CIWaitToCollectAllCrowns_003Ed__100(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public LevelManager _003C_003E4__this;

		public int coinsPerBuilding;
	}

	private sealed class _003C_003Ec__DisplayClass101_1
	{
		public Building b;

		public bool canMove;

		public _003C_003Ec__DisplayClass101_0 CS_0024_003C_003E8__locals1;

		internal void _003CIProlongedWin_003Eb__1()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Building> _003C_003E9__101_0;

		public static Func<Building, bool> _003C_003E9__120_0;

		internal int _003CIProlongedWin_003Eb__101_0(Building a, Building b)
		{
			return 0;
		}

		internal bool _003CGetRandomEnemyTeam_003Eb__120_0(Building building)
		{
			return false;
		}
	}

	private sealed class _003CIProlongedWin_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass101_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass101_1 _003C_003E8__2;

		private int _003CtotalBuildings_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CIProlongedWin_003Ed__101(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public float previousVolume;

		public LevelManager _003C_003E4__this;

		internal void _003CShowGameplayInterstitial_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public float previousVolume;

		public LevelManager _003C_003E4__this;

		internal void _003CIDelayShowPowerUpInterstitial_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003CIDelayShowPowerUpInterstitial_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass113_0 _003C_003E8__1;

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
		public _003CIDelayShowPowerUpInterstitial_003Ed__113(int _003C_003E1__state)
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

	private sealed class _003CIDelayApplyStartFloorsIncremental_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

		private int _003CaddFloor_003E5__2;

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
		public _003CIDelayApplyStartFloorsIncremental_003Ed__114(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass124_0
	{
		public int _ID;

		internal bool _003CGetBuildingByID_003Eb__0(Building building)
		{
			return false;
		}
	}

	private sealed class _003CInactivityTimer_003Ed__129 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

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
		public _003CInactivityTimer_003Ed__129(int _003C_003E1__state)
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

	private sealed class _003CActivityTimer_003Ed__132 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

		private float _003ClastTime_003E5__2;

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
		public _003CActivityTimer_003Ed__132(int _003C_003E1__state)
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

	private List<Building> _003Cbuildings_003Ek__BackingField;

	private List<Bot> bots;

	private bool powerUpPlayerBuildings;

	private bool showedFreeze;

	private bool willShowCaptureInterstitial;

	private Onboarding onboarding;

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private Tutorial tutorial;

	[SerializeField]
	private LineRenderer debugLineRenderer;

	[SerializeField]
	private GameObject coinPrefab;

	[SerializeField]
	private GameObject bossPrefab;

	public int LevelNumber;

	public GameCamera gameCamera;

	private GameManager manager;

	private GameUi gameUi;

	private bool cameraAnimated;

	private Dictionary<BuildingTeam, int> scoreMapping;

	private Dictionary<BuildingTeam, AvatarCustomizaion> avatarCustomizationMap;

	private Action contextualAction;

	private DateTime startTime;

	private DateTime lastCaptureInterstitialTime;

	private int allBuildingsScore;

	private bool _003CGameFinished_003Ek__BackingField;

	private bool _isLevelVariation;

	private float timeSinceLastAd;

	private int _connectionsCount;

	private int _cutsCount;

	private bool _usedFreeze;

	private bool _usedGoldenTower;

	private bool _usedPower;

	private bool _usedFastForward;

	private float _003CtotalInactivityTime_003Ek__BackingField;

	private float _003CtotalTime_003Ek__BackingField;

	private float _003CffTime_003Ek__BackingField;

	private float _003CcurrentInactivityTime_003Ek__BackingField;

	private float _inactivityTimeStep;

	private Coroutine _inactivityTimerCoroutine;

	private Coroutine _activityTimerCoroutine;

	private int _003CnbBuildingsLost_003Ek__BackingField;

	private float _goldenTowerBoostTimeLeft;

	private float _goldenTowerNextHapticTime;

	private float _previousDisconnectedTimeScale;

	public HazardManager HazardManager;

	public List<Building> buildings
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Onboarding Onboarding => null;

	public bool GameFinished
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool IsLevelVariation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int ConnectionsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int CutsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float totalInactivityTime
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public float totalTime
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public float ffTime
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public float currentInactivityTime
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public int nbBuildingsLost
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public bool IsGoldenTowerBoostActive => false;

	public float GoldenTowerBoostTimeLeft => 0f;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnPlayPressed(bool shouldPowerUpBuildings)
	{
	}

	private void OnGameConnectionLost()
	{
	}

	private void OnGameConnectionBack()
	{
	}

	private void ChangeAvatarCustmizations()
	{
	}

	private void Init()
	{
	}

	private IEnumerator IDelayedInit()
	{
		return null;
	}

	public AvatarCustomizaion GetAvatarCustomization(BuildingTeam _Team)
	{
		return (AvatarCustomizaion)null;
	}

	private void LateUpdate()
	{
	}

	private void CheckForIngameAds()
	{
	}

	public float GetTeamNormalizedScore(BuildingTeam _Team)
	{
		return 0f;
	}

	public void AddBuilding(Building newBuilding)
	{
	}

	public void AddBot(Bot b)
	{
	}

	private void OnBuildingCaptured(Building building, BuildingTeam oldTeam, Building fromBuilding)
	{
	}

	public void OnGoldenTowerActivated(ParticleSystem _activationFX)
	{
	}

	private bool ShowBuildingReaction(BuildingTeam _Team)
	{
		return false;
	}

	private bool CheckVictory()
	{
		return false;
	}

	private bool CheckDefeat()
	{
		return false;
	}

	private void OnLevelComplete()
	{
	}

	private void OnLevelFailed()
	{
	}

	private IEnumerator IWaitToCollectAllCrowns()
	{
		return null;
	}

	private IEnumerator IProlongedWin()
	{
		return null;
	}

	private void OnBuildingClicked(GameObject gmo)
	{
	}

	public void SetGoldenTowerUsed()
	{
	}

	public void SetPowerUsed()
	{
	}

	public void SetFastForwardUsed()
	{
	}

	public void FreezeOpponentBuildings()
	{
	}

	public void UnfreezeBuildings()
	{
	}

	public void SetAllBuildingsCanUpdate(bool can)
	{
	}

	private void AttemptShowCaptureInterstitial()
	{
	}

	private void ShowGameplayInterstitial(string tag)
	{
	}

	public float TimeElapsedSince(DateTime eltime)
	{
		return 0f;
	}

	public float GetPlayerDominationPercentage()
	{
		return 0f;
	}

	private IEnumerator IDelayShowPowerUpInterstitial()
	{
		return null;
	}

	private IEnumerator IDelayApplyStartFloorsIncremental()
	{
		return null;
	}

	public void ResetCaptureInterstitialTime()
	{
	}

	private void AddCoinLine()
	{
	}

	public void ClearAllBuildingsInRangeCache()
	{
	}

	private void OnPowerUpTutorialComplete()
	{
	}

	private void OnPowerUpTutorialShowed()
	{
	}

	public BuildingTeam GetRandomEnemyTeam()
	{
		//IL_0003: Expected I4, but got O
		return (BuildingTeam)null;
	}

	public Building GetRandomBuilding()
	{
		return null;
	}

	public Building GetRandomBuilding(Building buildingToExclude)
	{
		return null;
	}

	public Building GetRandomBuilding(BuildingTeam team, [Optional] Building buildingToExclude)
	{
		return null;
	}

	public Building GetBuildingByID(int _ID)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void TrackGameStarted()
	{
	}

	private void TrackGameFinished(bool _Win)
	{
	}

	public void StartInactivityTimer()
	{
	}

	private IEnumerator InactivityTimer()
	{
		return null;
	}

	public void StopInactivityTimer()
	{
	}

	public void StartActivityTimer()
	{
	}

	private IEnumerator ActivityTimer()
	{
		return null;
	}

	public void StopActivityTimer()
	{
	}

	private void _003CAddBuilding_003Eb__91_1()
	{
	}
}
