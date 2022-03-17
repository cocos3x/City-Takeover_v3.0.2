using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class GameAnalyticsProvider : BaseAnalyticsProviderWithLogger
	{
		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			//IL_0003: Expected I4, but got O
			return (VoodooSauce.AnalyticsProvider)null;
		}

		public GameAnalyticsProvider()
		{
		}

		internal GameAnalyticsProvider(bool initEvents)
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

		private static void TrackPurchase(VoodooIAPAnalyticsInfo purchaseInfo)
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties, string type, List<VoodooSauce.AnalyticsProvider> analyticsProviders)
		{
		}
	}
}
