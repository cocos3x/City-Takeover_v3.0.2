public class RNGMinigamesRemoteConfig
{
	public class PlacementInfo
	{
		public string id;

		public int drawType;

		public PlacementInfo(string p_id, int p_drawType)
		{
		}
	}

	public string[] placement;

	public string[] minigame;

	public int[] sessionCountRequirement;

	public int[] gameCountRequirement;

	public int[] drawType;

	public bool CheckConfig()
	{
		return false;
	}

	public PlacementInfo GetMinigame(string placementName)
	{
		return null;
	}

	private bool _ConditionsFulfilled(int i)
	{
		return false;
	}

	public static RNGMinigamesRemoteConfig FromRemoteConfig()
	{
		return null;
	}
}
