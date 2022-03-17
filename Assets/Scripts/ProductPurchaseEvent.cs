using System.Runtime.InteropServices;

namespace Voodoo.Sauce.IAP
{
	[StructLayout(0, Size = 1)]
	public struct ProductPurchaseEvent
	{
		private const string ConsumableProductEventName = "purchase_consumable";

		private const string NotConsumableProductEventName = "purchase_nonconsumable";

		private const string SubscriptionProductEventName = "purchase_subscription";

		private const string UnknownProductEventName = "product_unknown";

		private const string NoAdsProductEventName = "purchase_noads";

		internal static string GetAdjustName(ProductReceivedInfo purchaseInfo, string noAdsBundleId)
		{
			return "";
		}

		internal static PurchaseProductType GetType(string productId, IAPManager iapManager)
		{
			//IL_0003: Expected I4, but got O
			return (PurchaseProductType)null;
		}
	}
}
