using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class FirebaseAnalyticsProvider : BaseAnalyticsProviderWithLogger
	{
		[Serializable]
		public class ImpressionObject
		{
			public string adunit_id;

			public string adunit_name;

			public string adunit_format;

			public string app_version;

			public string id;

			public string currency;

			public double publisher_revenue;

			public string network_name;

			public string network_placement_id;

			public string adgroup_id;

			public string adgroup_name;

			public string adgroup_type;

			public string adgroup_priority;

			public string country;

			public string precision;
		}

		private const string TAG = "FirebaseAnalyticsWrapper";

		private readonly bool _useFirebaseAnalytics;

		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			//IL_0003: Expected I4, but got O
			return (VoodooSauce.AnalyticsProvider)null;
		}

		public FirebaseAnalyticsProvider()
		{
		}

		internal FirebaseAnalyticsProvider(bool useFirebaseAnalytics)
		{
		}

		public override void Instantiate(string mediation)
		{
		}

		public override void Initialize(bool consent, bool isChinaBuild)
		{
		}

		private static void RegisterEvents()
		{
		}

		private static void UnregisterEvents()
		{
		}

		private static void OnGameStarted(GameStartedParameters parameters)
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties, string type, List<VoodooSauce.AnalyticsProvider> analyticsProviders)
		{
		}

		private static void TrackPurchase(VoodooIAPAnalyticsInfo purchaseInfo)
		{
		}

		private static void OnFsShown(string tag, int fsCount, int adCount)
		{
		}

		private static void OnRvShown(string tag, int rvCount, int adCount)
		{
		}

		private static void OnBannerClicked(string adUnit)
		{
		}

		private static void OnFsClicked(string tag, string adUnit, int adCount)
		{
		}

		private static void OnRvClicked(string tag, string adUnit, int adCount)
		{
		}

		private static void OnImpressionTrackedEvent(string adUnitId, string impressionDataString)
		{
		}

		private void _003CInitialize_003Eb__6_0(bool success)
		{
		}
	}
}
