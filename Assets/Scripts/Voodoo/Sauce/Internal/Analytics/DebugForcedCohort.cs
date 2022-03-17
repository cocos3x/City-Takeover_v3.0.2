namespace Voodoo.Sauce.Internal.Analytics
{
	public class DebugForcedCohort
	{
		public int index;

		private VoodooSettings _settings;

		public string GetCohort()
		{
			return "";
		}

		public bool HasForcedNoCohort()
		{
			return false;
		}

		private bool IsNotEmpty()
		{
			return false;
		}

		public bool IsDebugCohort()
		{
			return false;
		}
	}
}
