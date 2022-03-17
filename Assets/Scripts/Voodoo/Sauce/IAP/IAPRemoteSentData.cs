using System;

namespace Voodoo.Sauce.IAP
{
	[Serializable]
	public class IAPRemoteSentData
	{
		public string bundleId;

		public string appVersion;

		public string platform;

		public string userId;

		public string advertisingId;

		public string idfv;

		public string vsVersion;

		public bool limitAdTracking;

		public string locale;

		public string connectivity;

		public string device;

		public string osVersion;

		public ReceiptPurchase receipt;

		public AdjustInfo adjustInfo;

		public VanInfo vanInfo;
	}
}
