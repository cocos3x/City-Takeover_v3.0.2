using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class MixpanelAnalyticsProvider : BaseAnalyticsProviderWithLogger
	{
		private readonly MixpanelParameters _parameters;

		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			//IL_0003: Expected I4, but got O
			return (VoodooSauce.AnalyticsProvider)null;
		}

		internal override string GetUninitializedErrorMessage()
		{
			return "";
		}

		public MixpanelAnalyticsProvider()
		{
		}

		internal MixpanelAnalyticsProvider(MixpanelParameters parameters)
		{
		}

		public override void Instantiate(string mediation)
		{
		}

		public override void Initialize(bool consent, bool isChinaBuild)
		{
		}

		private void RegisterEvents()
		{
		}

		private static void UnregisterEvents()
		{
		}

		private static void OnGameStarted(GameStartedParameters gameStartedParameters)
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void OnFsShown(string tag, int fsCount, int adCount)
		{
		}

		private static void OnRvShown(string tag, int rvCount, int adCount)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties, string type, List<VoodooSauce.AnalyticsProvider> analyticsProviders)
		{
		}

		private static void OnCrossPromoShown(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		private static void OnCrossPromoClick(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		private static void OnCrossPromoError(string errorMessage)
		{
		}

		private static void OnApplicationFirstLaunch()
		{
		}

		private static void OnApplicationLaunch()
		{
		}
	}
}
