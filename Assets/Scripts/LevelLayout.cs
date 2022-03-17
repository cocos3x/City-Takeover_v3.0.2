using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelLayout
{
	public List<SerializableEditorBuilding> buildings;

	public List<SerializableEditorBot> bots;

	public List<Vector3> buildings_pos;

	public List<Vector3> obstacles_pos;

	public List<Vector3> obstacles_rot;

	public List<Vector3> obstacles_scale;

	public bool isVariationPossible;
}
