namespace Voodoo.Sauce.IAP
{
	public class ProductReceivedInfo
	{
		public readonly string ConnectivityType;

		public readonly string DeviceLocal;

		public readonly string IsoCurrencyCode;

		public readonly double LocalizedPrice;

		public readonly string ProductId;

		public readonly string ProductName;

		public readonly PurchaseProductType ProductType;

		public readonly string Token;

		public readonly string TransactionID;

		public ProductReceivedInfo(string productId, PurchaseProductType productType, string transactionID, string isoCurrencyCode, double localizedPrice, string token, string productName)
		{
		}
	}
}
