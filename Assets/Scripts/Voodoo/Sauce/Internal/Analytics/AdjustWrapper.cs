using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class AdjustWrapper
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__11_0;

			internal void _003CInitializeAdjust_003Eb__11_0()
			{
			}
		}

		private const string TAG = "AdjustWrapper";

		private const string ADJUST_USER_ID_KEY = "vs_adjust_user_id";

		internal static AttributionData AttributionData;

		private static bool _isInitialized;

		private static readonly Queue<AdjustAnalyticsEvent> EventsQueue;

		internal static void Instantiate()
		{
		}

		public static void Initialize(string token, bool isTestMode, bool isChinaBuild)
		{
		}

		public static void TrackEvent(string eventName, [Optional] Dictionary<string, object> customVariables)
		{
		}

		public static void TrackAdRevenue(string eventName, string data)
		{
		}

		private static void AddAdjustSessionCallbackParameters()
		{
		}

		private static void AddAdjustSessionCallbackParameters(Dictionary<string, string> parameters)
		{
		}

		private static void InitializeAdjust(string adjustAppToken, bool isTestMode, bool isChinaBuild)
		{
		}

		internal static AttributionData GetAttributionData()
		{
			return null;
		}

		private static void LoadCachedUserId()
		{
		}

		internal static void SaveUserId()
		{
		}
	}
}
