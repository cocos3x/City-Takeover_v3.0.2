using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.GDPR.Utils
{
	public static class VoodooGDPRUtils
	{
		public enum GDPRType
		{
			Voodoo,
			VoodooSP,
			ATT
		}

		private const string PopupVersion = "2.1";

		private static readonly GDPRInfoList _analyticsSDKs;

		private static readonly GDPRInfoList _adNetworkSDKs;

		private static bool _areSDKsInitialized;

		public static GDPRType GetGDPRType()
		{
			//IL_0003: Expected I4, but got O
			return (GDPRType)null;
		}

		public static string GetLocale()
		{
			return "";
		}

		public static string GetOsType()
		{
			return "";
		}

		public static string GetUserStatus()
		{
			return "";
		}

		public static string GetVSVersion()
		{
			return "";
		}

		public static string GetAppVersion()
		{
			return "";
		}

		public static string GetPopupVersion()
		{
			return "";
		}

		public static bool IsValidEmail(string email)
		{
			return false;
		}

		public static List<string> GetCountryCodes()
		{
			return null;
		}

		public static string[] GetAdNetworkNames()
		{
			return null;
		}

		public static IEnumerable<string> GetAdvertisingPrivacyPolicyUrls()
		{
			return null;
		}

		public static string[] GetAnalyticsNames()
		{
			return null;
		}

		public static IEnumerable<string> GetAnalyticsPrivacyPolicyUrls()
		{
			return null;
		}

		private static void InitializeGDRPLinks()
		{
		}
	}
}
