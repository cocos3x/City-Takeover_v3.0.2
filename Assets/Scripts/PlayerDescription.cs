using System;
using UnityEngine;

public class PlayerDescription : IComparable<PlayerDescription>
{
	public string pseudo;

	public Sprite flag;

	public BuildingTeam team;

	public Color color;

	public bool mainPlayer;

	public int position;

	public int CompareTo(PlayerDescription _Other)
	{
		return 0;
	}
}
