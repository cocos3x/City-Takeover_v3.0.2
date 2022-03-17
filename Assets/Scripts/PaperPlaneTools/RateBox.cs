using System.Runtime.InteropServices;

namespace PaperPlaneTools
{
	public class RateBox
	{
		private static string statisticsPath;

		private static RateBox instance;

		private bool _003CDebugMode_003Ek__BackingField;

		private string _003CRateUrl_003Ek__BackingField;

		private RateBoxConditions _003CConditions_003Ek__BackingField;

		private RateBoxSettings _003CSettings_003Ek__BackingField;

		private RateBoxStatistics _003CStatistics_003Ek__BackingField;

		private RateBoxTextSettings _003CDefaultTextSettings_003Ek__BackingField;

		private IAlertPlatformAdapter _003CAlertAdapter_003Ek__BackingField;

		public static RateBox Instance => null;

		public bool DebugMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string RateUrl
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public RateBoxConditions Conditions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RateBoxSettings Settings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RateBoxStatistics Statistics
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public RateBoxTextSettings DefaultTextSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAlertPlatformAdapter AlertAdapter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private RateBox(RateBoxStatistics stat)
		{
		}

		public static string GetStoreUrl(string iTunesAppId, string googlePlayMarketAppBundleId)
		{
			return "";
		}

		public void Init(string rateUrl, [Optional] RateBoxConditions conditions, [Optional] RateBoxTextSettings textSettings, [Optional] RateBoxSettings settings)
		{
		}

		public void Show(string title, string message, string rateButtonTitle, string postponeButtonTilte, [Optional] string rejectButtonTitle)
		{
		}

		public void Show()
		{
		}

		public void ForceShow(string title, string message, string rateButtonTitle, string postponeButtonTilte, [Optional] string rejectButtonTitle)
		{
		}

		public void ForceShow()
		{
		}

		public void IncrementCustomCounter(int value = 1)
		{
		}

		public bool CheckConditionsAreMet()
		{
			return false;
		}

		public void ClearStatistics()
		{
		}

		public bool SaveStatistics()
		{
			return false;
		}

		private int Time()
		{
			return 0;
		}

		private void GoToRateUrl()
		{
		}

		private void DebugLog(string str)
		{
		}

		private void _003CForceShow_003Eb__37_0()
		{
		}

		private void _003CForceShow_003Eb__37_1()
		{
		}
	}
}
