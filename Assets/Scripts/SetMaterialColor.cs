using System;
using UnityEngine;

public class SetMaterialColor : MonoBehaviour
{
	[Serializable]
	public struct MaterialRecolor
	{
		public MeshRenderer meshRenderers;

		public string[] shaderNameId;
	}

	[SerializeField]
	private MaterialRecolor[] matRecolor;

	public void SetColor(Color color)
	{
	}
}
