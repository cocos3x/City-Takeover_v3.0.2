using System.Collections.Generic;
using UnityEngine;

public class BattleModePlayerColorData : ScriptableObject
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public BuildingTeam _Team;

		internal bool _003CGetColor_003Eb__0(PlayerDescriptionColor enemy)
		{
			return false;
		}
	}

	[SerializeField]
	private Color playerColor;

	[SerializeField]
	private List<PlayerDescriptionColor> enemiesColorDescription;

	public Color PlayerColor => (Color)null;

	public Color GetColor(BuildingTeam _Team)
	{
		return (Color)null;
	}
}
