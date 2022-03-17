using System;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsManager : MonoBehaviour
{
	[Serializable]
	public class MaterialFit
	{
		public BuildingTeam team;

		public Material mat;
	}

	[Serializable]
	public class BuildingMaterialFit
	{
		public BuildingTeam team;

		public Material lightMat;

		public Material darkMat;

		public Color selectorColor;
	}

	[Serializable]
	public class MaterialMeshFit
	{
		public BuildingTeam team;

		public Material mat;

		public Mesh mesh;
	}

	public Material goldenTowerWindow;

	public static MaterialsManager Instance;

	[SerializeField]
	private List<BuildingMaterialFit> buildings;

	[SerializeField]
	private List<MaterialFit> lines;

	private Dictionary<BuildingTeam, BuildingMaterialFit> buildingsMap;

	private Dictionary<BuildingTeam, MaterialFit> linesMap;

	private void Awake()
	{
	}

	private void Init()
	{
	}

	public BuildingMaterialFit GetBuildingFit(BuildingTeam team)
	{
		return null;
	}

	public MaterialFit GetLineFit(BuildingTeam team)
	{
		return null;
	}
}
