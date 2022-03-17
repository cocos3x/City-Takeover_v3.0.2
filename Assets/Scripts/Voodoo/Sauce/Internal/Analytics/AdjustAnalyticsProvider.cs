using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AdjustAnalyticsProvider : BaseAnalyticsProviderWithLogger, IAnalyticsAttributionProvider
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<string> _003C_003E9__7_0;

			public static Action<string, string, int> _003C_003E9__7_1;

			public static Action<string, string, int> _003C_003E9__7_2;

			public static Action<string, string> _003C_003E9__7_3;

			public static Action<string, float> _003C_003E9__7_4;

			internal void _003CRegisterEvents_003Eb__7_0(string adUnit)
			{
			}

			internal void _003CRegisterEvents_003Eb__7_1(string tag, string adUnit, int adCount)
			{
			}

			internal void _003CRegisterEvents_003Eb__7_2(string tag, string adUnit, int adCount)
			{
			}

			internal void _003CRegisterEvents_003Eb__7_3(string adUnit, string impressionData)
			{
			}

			internal void _003CRegisterEvents_003Eb__7_4(string adUnit, float height)
			{
			}
		}

		private static AdjustParameters _parameters;

		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			//IL_0003: Expected I4, but got O
			return (VoodooSauce.AnalyticsProvider)null;
		}

		public AdjustAnalyticsProvider()
		{
		}

		internal AdjustAnalyticsProvider(AdjustParameters parameters)
		{
		}

		public override void Instantiate(string mediation)
		{
		}

		public override void Initialize(bool consent, bool isChinaBuild)
		{
		}

		public AttributionData GetAttributionData()
		{
			return null;
		}

		private static void RegisterEvents()
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

		private static void OnBannerClicked()
		{
		}

		private static void OnFsClicked()
		{
		}

		private static void OnRvClicked()
		{
		}

		private static void OnImpressionTracked(string impressionData)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, string eventType, List<VoodooSauce.AnalyticsProvider> analyticsProviders)
		{
		}

		private static string GetAdjustToken()
		{
			return "";
		}

		private static bool IsTestMode()
		{
			return false;
		}
	}
}
