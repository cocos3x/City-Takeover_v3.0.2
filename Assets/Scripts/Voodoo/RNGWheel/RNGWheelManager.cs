using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Voodoo.EconomyBridge;

namespace Voodoo.RNGWheel
{
	public class RNGWheelManager : MonoBehaviour
	{
		public enum RNGWheelState
		{
			Opening,
			WaitingForSpin,
			SpinningAccel,
			Spinning,
			SpinningDecel,
			GrantingReward
		}

		private sealed class _003C_003Ec__DisplayClass37_0
		{
			public GameObject rewardGrantedClone;

			internal void _003CRewardGrantedAnim_003Eb__0()
			{
			}
		}

		private sealed class _003CManageSpinningCoroutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RNGWheelManager _003C_003E4__this;

			private Reward _003CtargetReward_003E5__2;

			private int _003CspinTarget_003E5__3;

			private float _003CtargetRotation_003E5__4;

			private float _003CspinAccelTime_003E5__5;

			private float _003CdecelDuration_003E5__6;

			private float _003CdecelRotationRange_003E5__7;

			private float _003CspinDecelTime_003E5__8;

			private float _003CdecelStartRotation_003E5__9;

			private string _003CpreviousSliceConfigRewardType_003E5__10;

			private bool _003CisSliceRebuildRequired_003E5__11;

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
			public _003CManageSpinningCoroutine_003Ed__52(int _003C_003E1__state)
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

		public List<RNGWheelSlice> slicePrefabsList;

		public Animator animator;

		public GameObject needle;

		public GameObject wheelRoot;

		public GameObject slicesParent;

		public Button skipButton;

		public Button spinButton;

		public RVButton spinAgainButton;

		public TextMeshProUGUI spinAgainButtonTxt;

		public RNGWheelRemoteConfig remoteConfig;

		public RNGRewardsRemoteConfig.DrawType drawType;

		private List<Reward> _rewardList;

		private List<RNGWheelSlice> _slices;

		private int currentSpinIndex;

		private float _currentSpinSpeed;

		private float _currentRotation;

		private float _previousRotation;

		private float _needleRotation;

		private int _currentWheelSliceIndex;

		private int _SpinningTriggerHash;

		private int _RewardLvl1TriggerHash;

		private int _RewardLvl2TriggerHash;

		private int _RewardLvl3TriggerHash;

		private int _RewardLvl4TriggerHash;

		private bool _spinButtonPressed;

		private Coroutine _ManageSpinningCoroutineInstance;

		private RNGWheelState _003Cstate_003Ek__BackingField;

		private const float _PRIZE_GRANTED_ANIM_HEIGHT = 0.75f;

		private const float _PRIZE_GRANTED_ANIM_DURATION = 1f;

		private const float _PRIZE_GRANTED_ANIM_FADEIN_DURATION = 0.2f;

		private const float _PRIZE_GRANTED_ANIM_FADEOUT_DURATION = 0.25f;

		private const float _SLICE_TARGET_ROTATION_MARGIN = 2f;

		private const float _SPIN_ACCEL_DURATION = 0.5f;

		private const float _SPIN_SPEED = 540f;

		private const float _MIN_END_SPIN_SPEED = 15f;

		private const float _MIN_DECEL_FULLTURNS = 1f;

		private const float _DECEL_TIME = 1.5f;

		private const float _DECEL_TIME_EXTRA_SPIN = 0.5f;

		private const int _MINOR_TICK_AMOUNT = 48;

		private const float _MAJOR_TICK_MAX_WHEEL_ANGLE = 20f;

		private const float _MINOR_TICK_MAX_WHEEL_ANGLE = 5f;

		private const float _MAJOR_TICK_MAX_NEEDLE_ROTATION = -20f;

		private const float _MINOR_TICK_MAX_NEEDLE_ROTATION = -10f;

		private const float _NEEDLE_ROTATION_FRICTION = 0.9f;

		private static RNGWheelManager _instance;

		private static object _lock;

		private static bool _isQuitting;

		public RNGWheelState state
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (RNGWheelState)null;
			}
			private set
			{
			}
		}

		public static RNGWheelManager Instance => null;

		public static List<T> ShuffleList<T>(List<T> ts)
		{
			return null;
		}

		public void Awake()
		{
		}

		public void RewardGrantedAnim(GameObject rewardGranted)
		{
		}

		private bool _BuildWheel()
		{
			return false;
		}

		private RNGWheelSlice _InstantiateSliceFromPrefab(int rewardIndex, float currentStartAngle, float sliceAngle)
		{
			return null;
		}

		private void _OnWheelSpinAgain(bool rvComplete)
		{
		}

		private void _OnStartFreeSpinWheel(BaseEventData eventData)
		{
		}

		private void _OnStartSpinWheel(BaseEventData eventData)
		{
		}

		private void _OnStopSpinWheel(BaseEventData eventData)
		{
		}

		private void _OnSkip()
		{
		}

		private IEnumerator ManageSpinningCoroutine()
		{
			return null;
		}

		private void _RebuildSlice(int sliceIndex)
		{
		}

		private float easeOutCubic(float x)
		{
			return 0f;
		}

		private int _rewardConfigToIndex(Reward reward)
		{
			return 0;
		}

		private int GetNextSpinTargetIndex(Reward targetReward)
		{
			return 0;
		}

		private int _GetCurrentWheelSliceIndex()
		{
			return 0;
		}

		public void UpdateWheelAndNeedleRotation(bool forceUpdate = false)
		{
		}

		public void OnApplicationQuit()
		{
		}
	}
}
