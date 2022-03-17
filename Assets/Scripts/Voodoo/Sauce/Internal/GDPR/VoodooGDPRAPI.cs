using System;
using System.Runtime.InteropServices;
using UnityEngine.Networking;

namespace Voodoo.Sauce.Internal.GDPR
{
	public static class VoodooGDPRAPI
	{
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public Action<NeedConsent> onSuccess;

			public Action onError;

			internal void _003CNeedConsent_003Eb__0(UnityWebRequest request)
			{
			}

			internal void _003CNeedConsent_003Eb__1(UnityWebRequest request)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public Action onSuccess;

			public Action onError;

			internal void _003CConsentInsights_003Eb__0(UnityWebRequest request)
			{
			}

			internal void _003CConsentInsights_003Eb__1(UnityWebRequest request)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Action<PrivacyRequest> onSuccess;

			public Action<PrivacyRequest> onError;

			internal void _003CPrivacyRequest_003Eb__0(UnityWebRequest request)
			{
			}

			internal void _003CPrivacyRequest_003Eb__1(UnityWebRequest request)
			{
			}
		}

		private const string BaseUrl = "https://api-gdpr.voodoo-tech.io/";

		public static void NeedConsent(NeedConsentParams data, Action<NeedConsent> onSuccess, Action onError)
		{
		}

		public static void ConsentInsights(ConsentInsightsParams data, [Optional] Action onSuccess, [Optional] Action onError)
		{
		}

		public static void PrivacyRequest(PrivacyRequestParams data, [Optional] Action<PrivacyRequest> onSuccess, [Optional] Action<PrivacyRequest> onError)
		{
		}
	}
}
