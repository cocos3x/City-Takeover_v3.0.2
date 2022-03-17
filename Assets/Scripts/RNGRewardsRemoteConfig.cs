public class RNGRewardsRemoteConfig
{
	public enum RewardGroup
	{
		Jackpot,
		Great,
		Good,
		Standard
	}

	public enum DrawType
	{
		firstIterationDraw,
		freeDraw,
		normalDraw,
		superDraw
	}

	public float[] firstIterationDrawWeight;

	public float[] freeDrawWeight;

	public float[] normalDrawWeight;

	public float[] superDrawWeight;

	public float[] GetWeightsForDrawType(DrawType drawType)
	{
		return null;
	}

	public RewardGroup DrawRandomRewardGroup(DrawType drawType)
	{
		//IL_0003: Expected I4, but got O
		return (RewardGroup)null;
	}

	public static RNGRewardsRemoteConfig FromRemoteConfig()
	{
		return null;
	}
}
