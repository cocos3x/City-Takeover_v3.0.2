public class AirshipConfig
{
	public enum AirshipReward
	{
		COINS,
		GROWTH,
		FREEZE,
		METEOR,
		SHIELD
	}

	public bool enabled;

	public int minDelayBetweenDrops;

	public int inactiveTimeToStartDrop;

	public int numberOfFreeAirshipsStart;

	public int numberOfAirshipsBetweenFS;

	public float rewardWeight_coins;

	public float rewardWeight_growth;

	public float rewardWeight_freeze;

	public float rewardWeight_meteor;

	public float rewardWeight_shield;

	public int rewardAmount_coins;

	public AirshipReward GetRandomReward()
	{
		//IL_0003: Expected I4, but got O
		return (AirshipReward)null;
	}
}
