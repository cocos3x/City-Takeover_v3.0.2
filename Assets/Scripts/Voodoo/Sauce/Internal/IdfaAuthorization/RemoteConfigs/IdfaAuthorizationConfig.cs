using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.Sauce.Internal.IdfaAuthorization.RemoteConfigs
{
	public static class IdfaAuthorizationConfig
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<string, IdfaAuthorizationFlowConfig>, string> _003C_003E9__15_0;

			internal string _003CGetFlow_003Eb__15_0(KeyValuePair<string, IdfaAuthorizationFlowConfig> key)
			{
				return "";
			}
		}

		private const string TAG = "IdfaAuthorizationConfig";

		private static readonly Dictionary<string, IdfaAuthorizationFlowConfig> WorldWideFlows;

		private static readonly Dictionary<string, IdfaAuthorizationFlowConfig> ChinaFlows;

		private static IdfaAuthorizationFlowConfig _flow;

		private static IdfaAuthorizationPopupLocalisation _popup;

		private static IdfaAuthorizationPopupBackgroundLocalisation _background;

		private static IdfaAuthorizationPurchasePopupLocalisation _purchasePopup;

		public static IdfaAuthorizationFlowConfig Flow => null;

		public static IdfaAuthorizationPopupLocalisation Popup => null;

		public static IdfaAuthorizationPopupBackgroundLocalisation Background => null;

		public static IdfaAuthorizationPurchasePopupLocalisation PurchasePopup => null;

		private static IdfaAuthorizationFlowConfig GetFlow()
		{
			return null;
		}

		public static T Get<T>(SystemLanguage language) where T : IdfaAuthorizationPopupLocalisation, new()
		{
			return null;
		}

		public static List<SystemLanguage> GetLanguages<T>() where T : IdfaAuthorizationPopupLocalisation, new()
		{
			return null;
		}
	}
}
