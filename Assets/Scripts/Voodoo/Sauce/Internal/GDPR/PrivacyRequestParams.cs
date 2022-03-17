using System;

namespace Voodoo.Sauce.Internal.GDPR
{
	[Serializable]
	public class PrivacyRequestParams
	{
		public string uuid;

		public string appVersion;

		public string vsVersion;

		public string bundleId;

		public string platform;

		public string locale;

		public string action;

		public string phoneNumber;

		public string phoneArea;

		public string email;

		public string studioName;

		public int gdprType;

		public string vendor_id;

		public string voodoo_user_id;
	}
}
