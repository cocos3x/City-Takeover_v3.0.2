using System;

namespace Voodoo.Sauce.Internal.GDPR
{
	[Serializable]
	public class NeedConsent
	{
		public bool need_consent;

		public bool already_consent;

		public bool embargoed_country;

		public string country_code;

		public bool ads_consent;

		public bool analytics_consent;

		public string texts;
	}
}
