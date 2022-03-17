using Firebase.Analytics;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class FirebaseAnalyticsEvent : BaseAnalyticsEvent
	{
		private Dictionary<string, object> _properties;

		public string GetEventName()
		{
			return "";
		}

		protected override string GetAnalyticsProviderName()
		{
			return "";
		}

		public FirebaseAnalyticsEvent(string eventName, Dictionary<string, object> properties)
		{
		}

		protected override void PerformTrackEvent()
		{
		}

		private void UpdateEventNameToFirebaseSpecific()
		{
		}

		private void UpdateParamKeysToFirebaseSpecific()
		{
		}

		private List<Parameter> ToParameters()
		{
			return null;
		}

		private static string GetFirebaseKey(string key)
		{
			return "";
		}
	}
}
