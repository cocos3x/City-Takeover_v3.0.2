using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using Voodoo.Sauce.Internal.AppRater;
using Voodoo.Sauce.Internal.CrossPromo;
using Voodoo.Sauce.Internal.CrossPromo.Models;
using Voodoo.Sauce.Internal.GDPR;
using Voodoo.Sauce.Internal.Misc;

namespace Voodoo.Sauce.Internal
{
	internal class VoodooSauceBehaviour : MonoBehaviour
	{
		private sealed class _003CCancelVoodooTuneInit_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int delayInSeconds;

			public VoodooSauceBehaviour _003C_003E4__this;

			private int _003Ctimer_003E5__2;

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
			public _003CCancelVoodooTuneInit_003Ed__22(int _003C_003E1__state)
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

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<int, bool> _003C_003E9__33_0;

			internal void _003CInitGdpr_003Eb__33_0(int screen, bool isGDPRShown)
			{
			}
		}

		private sealed class _003CCheckInternetAvailability_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private NetworkReachability _003Creachability_003E5__2;

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
			public _003CCheckInternetAvailability_003Ed__42(int _003C_003E1__state)
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

		private sealed class _003CInvokeAfterCoroutine_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public Action methodToCall;

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
			public _003CInvokeAfterCoroutine_003Ed__46(int _003C_003E1__state)
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

		private const string TAG = "VoodooSauceBehaviour";

		private static VoodooSauceBehaviour _instance;

		[SerializeField]
		private Voodoo.Sauce.Internal.AppRater.AppRater _appRaterPrefab;

		[SerializeField]
		private GameObject _voodooGdprCanvas;

		[SerializeField]
		private CohortDebugMenu _cohortDebugMenuPrefab;

		[SerializeField]
		private GameObject _bannerBackgroundPrefab;

		[SerializeField]
		internal GameObject inEditorAdsPrefab;

		[SerializeField]
		private GameObject _accessButton;

		private CohortDebugMenu _cohortDebugMenu;

		private VoodooSettings _settings;

		private static bool _startCalled;

		private static bool _initStarted;

		private static bool _initFinished;

		private static string _mediationName;

		public static Action OnInternetConnect;

		private Coroutine _cancelVoodooTuneInitCoroutine;

		private static event Action OnInitFinishedEvent
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

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void InitVoodooTune()
		{
		}

		private IEnumerator CancelVoodooTuneInit(int delayInSeconds)
		{
			return null;
		}

		private void InitVoodooSauce()
		{
		}

		private void InitAbTest()
		{
		}

		private void Start()
		{
		}

		private void OnConsentGiven(VoodooGDPR.GdprConsent gdpr)
		{
		}

		private static void OnConsentUpdated(VoodooGDPR.GdprConsent gdpr)
		{
		}

		public static void SubscribeOnInitFinishedEvent(Action onInitFinished)
		{
		}

		public static void UnSubscribeOnInitFinishedEvent(Action onInitFinished)
		{
		}

		public static void ShowCrossPromo([Optional] Action<AssetModel> onSuccess, [Optional] Action<CPShowFailType> onFailure)
		{
		}

		public static void HideCrossPromo()
		{
		}

		private static void InitAnalytics(bool consent)
		{
		}

		private void InitGdpr()
		{
		}

		private void InitAppRater()
		{
		}

		private void InitLogger()
		{
		}

		private static void InitFirebase()
		{
		}

		private static void InitFirebaseCrashlytics()
		{
		}

		private static void InitPromo()
		{
		}

		private void InitVoodooAds(bool consent)
		{
		}

		public static void ShowCohortDebugMenu()
		{
		}

		public static void CloseCohortDebugMenu()
		{
		}

		private static IEnumerator CheckInternetAvailability()
		{
			return null;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		internal static void InvokeAfter(Action methodToCall, float duration)
		{
		}

		internal static void InvokeCoroutine(IEnumerator coroutine)
		{
		}

		private static IEnumerator InvokeAfterCoroutine(Action methodToCall, float duration)
		{
			return null;
		}

		private void InstantiateAccessButton()
		{
		}

		private void DisposeAccessButton()
		{
		}

		private void OnDestroy()
		{
		}

		private void _003CInitVoodooTune_003Eb__21_0(string error)
		{
		}
	}
}
