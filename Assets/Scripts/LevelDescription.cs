using System;
using System.Collections.Generic;

public class LevelDescription
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<BuildingTeam> _003C_003E9__3_0;

		internal bool _003CGetEnemiesTeam_003Eb__3_0(BuildingTeam team)
		{
			return false;
		}
	}

	public int playerCount;

	public List<BuildingTeam> teamInvolved;

	public void AddTeam(BuildingTeam _Team)
	{
	}

	public List<BuildingTeam> GetEnemiesTeam()
	{
		return null;
	}
}
