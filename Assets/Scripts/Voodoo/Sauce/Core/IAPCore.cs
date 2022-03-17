using System;
using System.Collections.Generic;
using Voodoo.Sauce.Internal;
using Voodoo.Sauce.Internal.DebugScreen;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Core
{
	internal class IAPCore : IModule
	{
		public virtual void ShowDebugGeneralInfo(DebugGeneralInfoScreen screen, VoodooSettings settings)
		{
		}

		public virtual List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}

		internal virtual void Initialize(VoodooSettings voodooSettings)
		{
		}

		internal virtual void RefreshIapSubscriptionInfo()
		{
		}

		internal virtual void SetIapPurchaseDelegate(IPurchaseDelegate purchaseDelegate, VoodooSettings voodooSettings)
		{
		}

		internal virtual void RemoveIapPurchaseDelegate(IPurchaseDelegate purchaseDelegate)
		{
		}

		internal virtual void BuyIAPProduct(string productId, IPurchaseDelegate caller)
		{
		}

		internal virtual void RestoreIAPProduct(Action<RestorePurchasesResult> callback)
		{
		}

		internal virtual string GetLocalizedProductPrice(string productId)
		{
			return "";
		}

		internal virtual bool IsSubscribedProduct(string productId)
		{
			return false;
		}

		internal virtual bool IsSubscribedProduct()
		{
			return false;
		}

		internal virtual SubscriptionInfoContainer GetSubscriptionDetails(string productId)
		{
			return null;
		}
	}
}
