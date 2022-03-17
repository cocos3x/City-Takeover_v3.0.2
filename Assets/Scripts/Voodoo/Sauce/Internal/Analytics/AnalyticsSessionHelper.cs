using System;
using System.Timers;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AnalyticsSessionHelper
	{
		internal delegate void OnAdvertisingIdReceived(string advertisingId, bool limitAdTracking);

		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public OnAdvertisingIdReceived callback;

			internal void _003CGetAdvertisingId_003Eb__0(string advertisingId, bool trackingEnabled, string error)
			{
			}
		}

		private const string TAG = "Analytics - SessionHelper";

		private const string PlayerPrefSessionCountKey = "VOODOO_ANALYTICS_SESSION_COUNT";

		private DateTime _lastEventCreationDate;

		private Timer _sessionLengthTimer;

		private int _sessionIdRenewalIntervalInSeconds;

		private static string _advertisingId;

		private static bool _trackingEnabled;

		private int _003CSessionLength_003Ek__BackingField;

		private string _003CSessionId_003Ek__BackingField;

		private int _003CSessionCount_003Ek__BackingField;

		private static AnalyticsSessionHelper _defaultHelper;

		internal int SessionLength
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		internal string SessionId
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		internal int SessionCount
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public static AnalyticsSessionHelper DefaultHelper()
		{
			return null;
		}

		internal void Init()
		{
		}

		internal void OnNewEvent()
		{
		}

		internal static void GetAdvertisingId(OnAdvertisingIdReceived callback)
		{
		}

		private void Update()
		{
		}

		private void ResetSession()
		{
		}

		private void IncrementSessionCount()
		{
		}

		private void RefreshCreationDate()
		{
		}

		private void _003CInit_003Eb__21_0(object sender, ElapsedEventArgs args)
		{
		}
	}
}
