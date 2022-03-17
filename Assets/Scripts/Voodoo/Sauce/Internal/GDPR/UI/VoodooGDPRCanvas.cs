using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Voodoo.Sauce.Internal.GDPR.UI
{
	public class VoodooGDPRCanvas : MonoBehaviour
	{
		public static class GDPRScreen
		{
			public const int NoScreen = -1;

			public const int PrivacyScreen = 0;

			public const int DataSummaryScreen = 1;

			public const int DataSharingSettingsScreen = 2;

			public const int WarningScreen = 3;

			public const int LastWarningScreen = 4;

			public const int WarningBanner = 5;

			public const int SettingsScreen = 6;

			public const int AccessModifyScreen = 7;

			public const int DeleteScreen = 8;

			public const int DebugMainMenuScreen = 9;

			public const int IdfaScreen = 10;

			public const int MessageDialogScreen = 11;
		}

		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public string url1;

			internal void _003CFillContentHolderWithUrls_003Eb__0()
			{
			}
		}

		private sealed class _003CBannerAnimation_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool reverse;

			public VoodooGDPRCanvas _003C_003E4__this;

			public float duration;

			private RectTransform _003Crect_003E5__2;

			private Vector2 _003Cpos_003E5__3;

			private float _003Ctimer_003E5__4;

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
			public _003CBannerAnimation_003Ed__52(int _003C_003E1__state)
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

		private const string TAG = "VoodooGDPRCanvas";

		private static VoodooGDPRCanvas _instance;

		[SerializeField]
		private GameObject[] _screens;

		[SerializeField]
		private RectTransform[] _privacyPoliciesAdvertisingContent;

		[SerializeField]
		private RectTransform[] _privacyPoliciesAnalyticsContent;

		[SerializeField]
		private VoodooGDPRMessageDialog _messageDialog;

		[SerializeField]
		private GameObject _privacyPolicyPrefab;

		[SerializeField]
		private VoodooDebuggerInstructionPopup _instructionsPopup;

		private Dictionary<string, object> _jsonData;

		private int _currentScreen;

		private Color? _mainColor;

		private bool _adsConsent;

		private bool _analyticsConsent;

		public static bool IsShowing;

		private string _json;

		public static bool IsInitialized;

		private static bool _isSettingsShowing;

		public static Action<int, bool> OnGDPRStateChange;

		private Color MainColor => (Color)null;

		private void Awake()
		{
		}

		public static void Initialize()
		{
		}

		private void Init()
		{
		}

		public static void UpdateConsent(bool adsConsent, bool analyticsConsent)
		{
		}

		public static void UpdateTexts(string texts)
		{
		}

		public static string GetText(string key)
		{
			return "";
		}

		public static void ShowMessageDialog(string title, string message, Action closeCallback, string close = "Close")
		{
		}

		private void GeneratePrivacyPolicies()
		{
		}

		private void FillContentHolderWithUrls(Transform content, IEnumerable<string> urls)
		{
		}

		private void UpdateTextsAndColors(string json)
		{
		}

		private static string ReplaceAll(string text, Dictionary<string, string> all)
		{
			return "";
		}

		public void SetAdsConsent(bool consent)
		{
		}

		public void SetAnalyticsConsent(bool consent)
		{
		}

		private static void OpenUrl(string url)
		{
		}

		public void OpenPrivacyPolicy()
		{
		}

		public void OpenScreen(int index)
		{
		}

		public void CloseAndGiveConsent(bool overrideConsent)
		{
		}

		public static void Close()
		{
		}

		private void CloseCurrentScreen()
		{
		}

		public void CloseCurrentScreenOrShowWarning()
		{
		}

		public static void ShowPrivacyAuthorization()
		{
		}

		public void OpenSettingsMenu()
		{
		}

		public void CloseSettingsMenu()
		{
		}

		public static void ShowSettings()
		{
		}

		public static void CloseSettings()
		{
		}

		public static void ShowDebugger()
		{
		}

		public static void ShowDebuggerInstructionPopup(string instruction, bool showUserId, [Optional] UnityAction buttonCallback)
		{
		}

		public static void ShowBanner(bool forceDisplay)
		{
		}

		private static bool ShouldDisplay(bool forceDisplay)
		{
			return false;
		}

		public void CloseBanner()
		{
		}

		private void ShowBannerWithAnimation()
		{
		}

		private IEnumerator BannerAnimation(float duration, bool reverse)
		{
			return null;
		}

		public static bool GetAdsConsent()
		{
			return false;
		}

		public static bool GetAnalyticsConsent()
		{
			return false;
		}
	}
}
