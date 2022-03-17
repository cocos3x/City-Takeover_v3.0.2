using System.Collections.Generic;

namespace GameAnalyticsSDK.Setup
{
	public class Studio
	{
		private string _003CName_003Ek__BackingField;

		private string _003CID_003Ek__BackingField;

		private string _003COrganizationID_003Ek__BackingField;

		private List<Game> _003CGames_003Ek__BackingField;

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

		public string OrganizationID
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public List<Game> Games
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Studio(string name, string id, string orgId, List<Game> games)
		{
		}

		public static string[] GetStudioNames(List<Studio> studios, bool addFirstEmpty = true)
		{
			return null;
		}

		public static string[] GetGameNames(int index, List<Studio> studios)
		{
			return null;
		}
	}
}
