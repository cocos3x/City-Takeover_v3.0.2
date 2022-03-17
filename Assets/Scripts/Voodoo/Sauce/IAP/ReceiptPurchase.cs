using System;

namespace Voodoo.Sauce.IAP
{
	[Serializable]
	public class ReceiptPurchase
	{
		public string transactionId;

		public string type;

		public string token;

		public string productId;

		public double price;

		public string currency;

		public string productName;

		public string sharedSecretId;
	}
}
