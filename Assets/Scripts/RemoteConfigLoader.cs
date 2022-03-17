using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RemoteConfigLoader : MonoBehaviour
{
	private sealed class _003CEmergencyDelay_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float _Delay;

		public RemoteConfigLoader _003C_003E4__this;

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
		public _003CEmergencyDelay_003Ed__26(int _003C_003E1__state)
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

	public static bool IsInitialized;

	public bool useDebug;

	[SerializeField]
	private ScriptableRemoteConfigSettings _scriptableRemoteConfigSettings;

	public static RemoteConfigSettings RemoteSettings;

	public static MultiplayerSettings MultiplayerSettings;

	public static EndGameMultiplierRVConfig EndGameMultiplierRVConfig;

	public static FSDuringGameplayConfig FSDuringGameplayConfig;

	public static FastForwardConfig FastForwardConfig;

	public static PowerUpsConfig PowerUpsConfig;

	public static GoldenTowerConfig GoldenTowerConfig;

	public static LevelOrderConfig LevelOrderConfig;

	public static MultiplyArmyConfig MultiplyArmyConfig;

	public static IncrementalConfig IncrementalConfig;

	public static FinishConditionFasterConfig FinishConditionFasterConfig;

	public static SkipLevelConfig SkipLevelConfig;

	public static WinStreakConfig WinStreakConfig;

	public static EnvironmentHazardConfig EnvironmentHazardConfig;

	public static ProgressionStarsConfig ProgressionStarsConfig;

	public static AirshipConfig AirshipConfig;

	public static BuildingSkinsConfig BuildingSkinsConfig;

	public static NewShopConfig NewShopConfig;

	public static LightSkinShopConfig LightSkinShopConfig;

	public static event Action OnInitFinishedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private IEnumerator EmergencyDelay(float _Delay)
	{
		return null;
	}

	private void OnVoodooSauceInitFinished()
	{
	}

	private void InitializeABTest()
	{
	}
}
