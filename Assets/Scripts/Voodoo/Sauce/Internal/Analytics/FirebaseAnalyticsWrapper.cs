using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class FirebaseAnalyticsWrapper
	{
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public Action<bool> callback;

			internal void _003CInitialize_003Eb__0(bool success)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<string, object>, string> _003C_003E9__5_0;

			internal string _003CTrackEvent_003Eb__5_0(KeyValuePair<string, object> property)
			{
				return "";
			}
		}

		private const string TAG = "FirebaseAnalyticsWrapper";

		private static bool _isInitialized;

		private static bool _isDisabled;

		private static readonly Queue<FirebaseAnalyticsEvent> EventsQueue;

		internal static void Initialize(bool consent, Action<bool> callback)
		{
		}

		internal static void TrackEvent(string eventName, [Optional] Dictionary<string, object> properties)
		{
		}

		internal static void TrackPurchase(VoodooIAPAnalyticsInfo purchaseInfo)
		{
		}

		private static void Disable()
		{
		}
	}
}
