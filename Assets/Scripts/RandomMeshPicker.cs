using System.Collections.Generic;
using UnityEngine;

public class RandomMeshPicker : MonoBehaviour
{
	[SerializeField]
	private MeshFilter filter;

	[SerializeField]
	private List<Mesh> meshes;

	private void OnEnable()
	{
	}
}
