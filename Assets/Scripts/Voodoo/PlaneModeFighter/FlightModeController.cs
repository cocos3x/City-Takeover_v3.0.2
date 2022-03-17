using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Voodoo.PlaneModeFighter
{
	public class FlightModeController : MonoBehaviour, IPurchaseDelegate
	{
		private sealed class _003C_WaitForVS_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlightModeController _003C_003E4__this;

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
			public _003C_WaitForVS_003Ed__20(int _003C_003E1__state)
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

		private sealed class _003C_InGameDisconnectionTrackerCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlightModeController _003C_003E4__this;

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
			public _003C_InGameDisconnectionTrackerCoroutine_003Ed__30(int _003C_003E1__state)
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

		private sealed class _003C_ShakeTryAgainButtonCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlightModeController _003C_003E4__this;

			private RectTransform _003CbuttonRT_003E5__2;

			private float _003CshakeTime_003E5__3;

			private float _003CphaseTime_003E5__4;

			private float _003CmaxDisplacement_003E5__5;

			private float _003CcurrentTime_003E5__6;

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
			public _003C_ShakeTryAgainButtonCoroutine_003Ed__31(int _003C_003E1__state)
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

		private static FlightModeController _003CInstance_003Ek__BackingField;

		public bool SimulateOffline;

		[SerializeField]
		private GameObject _PopUpBlocker;

		[SerializeField]
		private GameObject _popupTryAgainButton;

		[SerializeField]
		private GameObject _popupNoAdsButton;

		[SerializeField]
		private GameObject _noAdsPurchaseNotAvailable;

		private FlightModeConfig _config;

		private bool _isCurrentlyOnline;

		private bool _isInGamePopupOpen;

		private Coroutine _inGameDisconnectionTrackerCoroutineInstance;

		private Coroutine _shakeTryAgainButtonCoroutineInstance;

		private Action _onInGameDisconnection;

		private Action _onInGameReconnection;

		private Vector2 _popupTryAgainButtonAnchoredPos;

		private bool VSCompleted;

		private List<VoodooSauce.AnalyticsProvider> _analyticsProviders;

		public static FlightModeController Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator _WaitForVS()
		{
			return null;
		}

		private void OnVoodooSauceInitFinished()
		{
		}

		public void NoAdsPurchaseTry()
		{
		}

		public static void TryStartGame(Action onStart)
		{
		}

		private void _TryStartGame(Action onStart)
		{
		}

		public static void RegisterToInGameDisconnection(Action onDisconnected, Action onReconnected)
		{
		}

		private void _RegisterToInGameDisconnection(Action onDisconnected, Action onReconnected)
		{
		}

		public static void UnregisterFromInGameDisconnection()
		{
		}

		private void _UnregisterFromInGameDisconnection()
		{
		}

		public void ManualRetryConnection()
		{
		}

		private IEnumerator _InGameDisconnectionTrackerCoroutine()
		{
			return null;
		}

		private IEnumerator _ShakeTryAgainButtonCoroutine()
		{
			return null;
		}

		private void _StopShakeTryAgainButtonCoroutine()
		{
		}

		private void _ShowPopup()
		{
		}

		private void _HidePopup()
		{
		}

		private void _ShowInGamePopup(bool playCallback = true)
		{
		}

		private void _HideInGamePopup(bool playCallback = true)
		{
		}

		public void _AnalyticsEventPopUpShown()
		{
		}

		private void _AnalyticsEventPopUpInGameShown()
		{
		}

		private void _AnalyticsEventPopUpInGameHidden()
		{
		}

		public void OnInitializeSuccess()
		{
		}

		public void OnInitializeFailure(VoodooInitializationFailureReason reason)
		{
		}

		public void OnInitializeFailure(InitializationFailureReason reason)
		{
		}

		public void OnPurchaseComplete(string productId)
		{
		}

		public void OnPurchaseFailure(string productId, VoodooPurchaseFailureReason reason, string transactionId)
		{
		}

		public void OnPurchaseFailure(string productId, PurchaseFailureReason reason)
		{
		}
	}
}
