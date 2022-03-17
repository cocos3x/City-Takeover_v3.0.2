using System.Runtime.InteropServices;
using UnityEngine;

public class ProgressMapRegionDatas : ScriptableObject
{
	[SerializeField]
	private RegionsManager.VisualRegion m_RegionInGame;

	[SerializeField]
	private GameObject m_EnvironmentObjects;

	[SerializeField]
	private bool m_RandomRot;

	[SerializeField]
	private Vector2 m_ScaleMultiplyBetween;

	[SerializeField]
	private string m_ShaderColorValue;

	[SerializeField]
	private Color m_ColorIsland;

	[SerializeField]
	private string m_ShaderTextureValue;

	[SerializeField]
	private Texture m_TextureIsland;

	[SerializeField]
	private Material m_WaterMaterial;

	public void SetWaterMat(MeshRenderer target)
	{
	}

	public void SetIslsand(NodeEnvironment environment)
	{
	}

	public GameObject CreateProps(Vector3 position, [Optional] Transform parent)
	{
		return null;
	}

	public void LoadRegionLevel()
	{
	}
}
