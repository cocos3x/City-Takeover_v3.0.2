using System.Collections.Generic;

namespace GameAnalyticsSDK.Setup
{
	public class Organization
	{
		private string _003CName_003Ek__BackingField;

		private string _003CID_003Ek__BackingField;

		private List<Studio> _003CStudios_003Ek__BackingField;

		public string Name
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string ID
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public List<Studio> Studios
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Organization(string name, string id)
		{
		}

		public static string[] GetOrganizationNames(List<Organization> organizations, bool addFirstEmpty = true)
		{
			return null;
		}
	}
}
