using UnityEngine.Purchasing;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.IAP
{
	public static class IAPExtension
	{
		internal static ProductReceivedInfo ToProductReceivedInfo(this Product product, IAPManager iapManager)
		{
			return null;
		}

		internal static ProductType GetProductType(this ProductDescriptor product)
		{
			//IL_0003: Expected I4, but got O
			return (ProductType)null;
		}

		internal static VoodooPurchaseFailureReason ToVoodooPurchaseFailureReason(this PurchaseFailureReason purchaseFailureReason)
		{
			//IL_0003: Expected I4, but got O
			return (VoodooPurchaseFailureReason)null;
		}

		internal static VoodooInitializationFailureReason ToVoodooInitializationFailureReason(this InitializationFailureReason initializationFailureReason)
		{
			//IL_0003: Expected I4, but got O
			return (VoodooInitializationFailureReason)null;
		}

		internal static SubscriptionResult ToSubscriptionResult(this Result result)
		{
			//IL_0003: Expected I4, but got O
			return (SubscriptionResult)null;
		}
	}
}
