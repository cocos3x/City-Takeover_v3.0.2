namespace Voodoo.Sauce.Internal.IAP
{
	internal static class VoodooPremium
	{
		private const string TAG = "VoodooPremium";

		private const string PrefsPremium = "VoodooSauce.Premium";

		private const string PremiumPeriod = "VoodooSauce.PremiumPeriod";

		public static void EnablePremium()
		{
		}

		public static void SetPremiumPeriod(bool isPremiumPeriodActive)
		{
		}

		private static void DisableAds()
		{
		}

		public static void SetFreePeriod(bool isFreePeriodActive)
		{
		}

		public static bool IsPremium()
		{
			return false;
		}

		public static bool IsIAPPremium()
		{
			return false;
		}

		public static bool HasPremiumPeriod()
		{
			return false;
		}
	}
}
