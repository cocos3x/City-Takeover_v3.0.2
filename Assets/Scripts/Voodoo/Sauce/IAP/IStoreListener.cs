using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.IAP
{
	public interface IStoreListener : UnityEngine.Purchasing.IStoreListener
	{
		void Init(IEnumerable<ProductDescriptor> products);

		void BuyProduct(string productId);

		void RestorePurchases(Action<RestorePurchasesResult> successCallback);

		string GetLocalizedProductPrice(string productId);

		bool IsPurchasableProduct(string productId);

		bool IsSubscribed();

		bool IsSubscribed(string productId);

		SubscriptionInfoContainer GetSubscriptionInfo(string productId);

		void RefreshSubscriptionInfo();
	}
}
