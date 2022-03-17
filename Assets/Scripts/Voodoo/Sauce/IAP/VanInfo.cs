using System;

namespace Voodoo.Sauce.IAP
{
	[Serializable]
	public class VanInfo
	{
		public string segment_uuid;

		public string ab_test_uuid;

		public string cohort_uuid;

		public string version_uuid;

		public string session_id;

		public int session_length;

		public int session_count;
	}
}
