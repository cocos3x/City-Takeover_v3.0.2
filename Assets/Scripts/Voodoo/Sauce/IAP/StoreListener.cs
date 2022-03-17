using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.IAP
{
	internal class StoreListener : IStoreListener, UnityEngine.Purchasing.IStoreListener
	{
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public StoreListener _003C_003E4__this;

			public PurchaseEventArgs args;

			internal void _003CProcessPurchase_003Eb__0(bool result)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public string productId;

			internal bool _003CGetLocalizedProductPrice_003Eb__0(Product p)
			{
				return false;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<InitializationFailureReason> _003C_003E9__31_1;

			internal void _003CRefreshSubscriptionInfo_003Eb__31_1(InitializationFailureReason reason)
			{
			}
		}

		private const string TAG = "StoreListener";

		private const string GOOGLE_PLAY = "GooglePlay";

		private const string APPLE_APP_STORE = "AppleAppStore";

		private const string MAC_APP_STORE = "MacAppStore";

		private IAppleExtensions _appleExtensions;

		private bool _hasSubscriptions;

		private bool _isInitialized;

		private string _purchasingProductId;

		private IAPManager _iapManager;

		private IStoreController _storeController;

		private IExtensionProvider _storeExtensionProvider;

		private Dictionary<string, SubscriptionInfoContainer> _subscriptionsInfos;

		public StoreListener(IAPManager iapManager)
		{
		}

		public void Init(IEnumerable<ProductDescriptor> products)
		{
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason reason)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			//IL_0003: Expected I4, but got O
			return (PurchaseProcessingResult)null;
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
		{
		}

		public void BuyProduct(string productId)
		{
		}

		public bool IsPurchasableProduct(string productId)
		{
			return false;
		}

		public void RestorePurchases(Action<RestorePurchasesResult> successCallback)
		{
		}

		public string GetLocalizedProductPrice(string productId)
		{
			return "";
		}

		private static void LogProductInfo(Product product)
		{
		}

		private bool CheckIfProductIsAvailableForSubscriptionManager(string receipt)
		{
			return false;
		}

		private bool ProductHasSubscriptionInfo(Product product)
		{
			return false;
		}

		private void UpdateSubscriptionInfo(Product product)
		{
		}

		private void InitializeSerializedSubscriptions()
		{
		}

		private void InitializeSubscriptions()
		{
		}

		public SubscriptionInfoContainer GetSubscriptionInfo(string productId)
		{
			return null;
		}

		public bool IsSubscribed()
		{
			return false;
		}

		public bool IsSubscribed(string productId)
		{
			return false;
		}

		public void RefreshSubscriptionInfo()
		{
		}

		private void _003CRefreshSubscriptionInfo_003Eb__31_0()
		{
		}
	}
}
