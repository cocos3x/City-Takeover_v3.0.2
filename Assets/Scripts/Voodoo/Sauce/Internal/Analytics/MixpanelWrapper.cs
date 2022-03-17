using mixpanel;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class MixpanelWrapper
	{
		public const string TAG = "MixpanelWrapper";

		private static bool _isInitialized;

		private static bool _isDisabled;

		private static readonly Queue<MixpanelEvent> QueuedEvents;

		public static bool Initialize(string mixpanelToken, bool consent)
		{
			return false;
		}

		public static void TrackEvent(string eventName, [Optional] Dictionary<string, object> eventProperties)
		{
		}

		public static void TrackTimedEvent(string eventName)
		{
		}

		private static void SetConsent(bool consent)
		{
		}

		private static bool Instantiate(string mixpanelToken)
		{
			return false;
		}

		private static void Disable()
		{
		}

		private static void RegisterMixpanelSuperProperties()
		{
		}

		private static Value GetValuesFromProperties(Dictionary<string, object> eventProperties)
		{
			return null;
		}

		private static string GetPlatform()
		{
			return "";
		}
	}
}
