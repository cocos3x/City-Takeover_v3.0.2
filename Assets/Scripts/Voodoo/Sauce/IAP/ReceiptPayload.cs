using System;

namespace Voodoo.Sauce.IAP
{
	[Serializable]
	internal class ReceiptPayload
	{
		public string orderId;

		public string packageName;

		public string productId;

		public string purchaseTime;

		public string purchaseState;

		public string developerPayload;

		public string purchaseToken;
	}
}
