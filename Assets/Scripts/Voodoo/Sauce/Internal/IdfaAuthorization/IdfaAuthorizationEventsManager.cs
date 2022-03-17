using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.IdfaAuthorization
{
	public static class IdfaAuthorizationEventsManager
	{
		private enum ScreenName
		{
			voodoo_popup,
			apple_popup,
			gdpr_popup,
			privacy_popup,
			consent_or_purchase_popup,
			purchase_popup
		}

		private enum EventName
		{
			screen_view,
			button_click
		}

		private enum Property
		{
			screen_name,
			voodoo_popup_counter,
			button,
			toggle_ads,
			toggle_analytics
		}

		public enum VoodooPopupButton
		{
			proceed,
			later,
			background_later
		}

		public enum ApplePopupButton
		{
			allow,
			deny
		}

		public enum GDPRPopupButton
		{
			proceed,
			more_info,
			more_info_sdk,
			more_info_ads,
			more_info_analytics,
			more_info_age_limit
		}

		public enum PrivacyPopupButton
		{
			proceed,
			more_info,
			more_info_sdk,
			more_info_age_limit
		}

		public enum ConsentOrPurchasePopupButton
		{
			consent,
			purchase
		}

		public enum PurchasePopupButton
		{
			purchase,
			cancel
		}

		private static string EventType;

		private static List<VoodooSauce.AnalyticsProvider> analyticsProviders;

		public static void OnVoodooIdfaAuthorizationDisplay(int voodooPopupCount)
		{
		}

		public static void OnVoodooIdfaAuthorizationClick(VoodooPopupButton voodooPopupButton, int voodooPopupCount)
		{
		}

		public static void OnAppleIdfaAuthorizationDisplay(int voodooPopupCount)
		{
		}

		public static void OnAppleIdfaAuthorizationClick(ApplePopupButton applePopupButton, int voodooPopupCount)
		{
		}

		public static void OnGDPRDisplay(int voodooPopupCount)
		{
		}

		public static void OnGDPRProceedClick(bool ads, bool analytics, int voodooPopupCount)
		{
		}

		public static void OnGDPRClick(GDPRPopupButton GDPRPopupButton, int voodooPopupCount)
		{
		}

		public static void OnPrivacyDisplay(int voodooPopupCount)
		{
		}

		public static void OnPrivacyClick(PrivacyPopupButton privacyPopupButton, int voodooPopupCount)
		{
		}

		public static void OnConsentOrPurchaseDisplay(int voodooPopupCount)
		{
		}

		public static void OnConsentOrPurchaseClick(ConsentOrPurchasePopupButton consentOrPurchasePopupButton, int voodooPopupCount)
		{
		}

		public static void OnPurchaseDisplay(int voodooPopupCount)
		{
		}

		public static void OnPurchaseClick(PurchasePopupButton purchasePopupButton, int voodooPopupCount)
		{
		}
	}
}
