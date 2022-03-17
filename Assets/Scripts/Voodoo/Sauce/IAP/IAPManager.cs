using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal;
using Voodoo.Sauce.Internal.DebugScreen;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.IAP
{
	internal class IAPManager : IAPCore
	{
		private const string TAG = "IAPManager";

		private readonly List<IPurchaseDelegate> _purchaseDelegateList;

		private ProductDescriptor[] _products;

		private IStoreListener _storeListener;

		private bool _initialized;

		private VoodooSettings _voodooSettings;

		private bool _isEnabled;

		private IPurchaseDelegate _latestCaller;

		private const string SettingsWrongAndroidProductIDWarning = "\n INVALID PRODUCT ID DETECTED \n\n Android product ids may only contain numbers, lowercase letters, underscores, and periods. \n\n The following product IDs will automatically be changed to conform to Android's naming rules: \n\n\n";

		private static readonly string IgnoringGooglePlayStoreKeyNotObfuscatedWarning;

		private const string GoogleStoreKeyNotObfuscatedError = "GooglePlay Store Key has not been obfuscated. If you wish to publish your app with IAP purchases on Android, you MUST obfuscate your google key by going to Window > UnityIAP > Receipt Validation Obfuscator. If this is your first build, you can ignore this message and send this build on the Google Play Store";

		private static string GooglePlayTanglePathV2 => "";

		private static string GooglePlayTanglePathV3 => "";

		internal override void Initialize(VoodooSettings voodooSettings)
		{
		}

		internal void OnInitializeFailed(InitializationFailureReason reason)
		{
		}

		internal void OnInitializeSuccess()
		{
		}

		internal override void SetIapPurchaseDelegate(IPurchaseDelegate purchaseDelegate, VoodooSettings voodooSettings)
		{
		}

		internal override void RemoveIapPurchaseDelegate(IPurchaseDelegate purchaseDelegate)
		{
		}

		internal void ProcessPurchaseValidation(Product product, Action<bool> callback)
		{
		}

		internal void ProcessPurchase(Product product)
		{
		}

		internal void OnPurchaseFailed(string productId, VoodooPurchaseFailureReason reason, string transactionId)
		{
		}

		internal override void BuyIAPProduct(string productId, IPurchaseDelegate caller)
		{
		}

		internal override void RestoreIAPProduct(Action<RestorePurchasesResult> successCallback)
		{
		}

		internal override string GetLocalizedProductPrice(string productId)
		{
			return "";
		}

		internal bool IsPurchasableProduct(string productId)
		{
			return false;
		}

		internal override bool IsSubscribedProduct()
		{
			return false;
		}

		internal override SubscriptionInfoContainer GetSubscriptionDetails(string productId)
		{
			return null;
		}

		internal override bool IsSubscribedProduct(string productId)
		{
			return false;
		}

		internal override void RefreshIapSubscriptionInfo()
		{
		}

		internal ProductType GetProductType(string productId)
		{
			//IL_0003: Expected I4, but got O
			return (ProductType)null;
		}

		public ProductDescriptor[] GetProductDescriptor()
		{
			return null;
		}

		public override void ShowDebugGeneralInfo(DebugGeneralInfoScreen screen, VoodooSettings voodooSettings)
		{
		}

		public override List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}

		private void CheckProductIds(VoodooSettings settings, List<IntegrationCheckMessage> messages)
		{
		}

		private void CheckGoogleTangle(VoodooSettings settings, List<IntegrationCheckMessage> messages)
		{
		}

		private bool IsGooglePlayTanglePopulated()
		{
			return false;
		}

		private bool IsGooglePlayTanglePopulated(string path)
		{
			return false;
		}
	}
}
