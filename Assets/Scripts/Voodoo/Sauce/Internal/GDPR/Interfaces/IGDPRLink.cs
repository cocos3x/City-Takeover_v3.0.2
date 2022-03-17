namespace Voodoo.Sauce.Internal.GDPR.Interfaces
{
	public interface IGDPRLink
	{
		string SDKName
		{
			get;
		}

		string PrivacyPolicyUrl
		{
			get;
		}

		GDPRSDKType SDKType
		{
			get;
		}
	}
}
