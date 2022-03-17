using System.Collections.Generic;

public class EnvironmentHazardConfig
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public int level;

		internal bool _003CGetHazardForLevel_003Eb__0(int x)
		{
			return false;
		}

		internal bool _003CGetHazardForLevel_003Eb__1(int x)
		{
			return false;
		}

		internal bool _003CGetHazardForLevel_003Eb__2(int x)
		{
			return false;
		}
	}

	public bool IsEnabled;

	public bool UseFS;

	public float SecondsBetweenHazards;

	public float UIWarningSeconds;

	public List<int> IceTornadoLevels;

	public List<int> MeteorLevels;

	public List<int> ThunderLevels;

	public HazardManager.HazardType GetHazardForLevel(int level)
	{
		//IL_0003: Expected I4, but got O
		return (HazardManager.HazardType)null;
	}
}
