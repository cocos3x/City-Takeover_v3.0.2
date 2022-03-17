using System;
using System.Collections.Generic;
using UnityEngine;

public class QuickOutline : MonoBehaviour
{
	public enum Mode
	{
		OutlineAll,
		OutlineVisible,
		OutlineHidden,
		OutlineAndSilhouette,
		SilhouetteOnly
	}

	[Serializable]
	private class ListVector3
	{
		public List<Vector3> data;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Vector3, int, KeyValuePair<Vector3, int>> _003C_003E9__30_0;

		public static Func<KeyValuePair<Vector3, int>, Vector3> _003C_003E9__30_1;

		internal KeyValuePair<Vector3, int> _003CSmoothNormals_003Eb__30_0(Vector3 vertex, int index)
		{
			return (KeyValuePair<Vector3, int>)null;
		}

		internal Vector3 _003CSmoothNormals_003Eb__30_1(KeyValuePair<Vector3, int> pair)
		{
			return (Vector3)null;
		}
	}

	private static HashSet<Mesh> registeredMeshes;

	[SerializeField]
	private Mode outlineMode;

	[SerializeField]
	private Color outlineColor;

	[SerializeField]
	private float outlineWidth;

	[SerializeField]
	private bool precomputeOutline;

	[SerializeField]
	private List<Mesh> bakeKeys;

	[SerializeField]
	private List<ListVector3> bakeValues;

	private Renderer[] renderers;

	private Material outlineMaskMaterial;

	private Material outlineFillMaterial;

	private bool needsUpdate;

	public Mode OutlineMode
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (Mode)null;
		}
		set
		{
		}
	}

	public Color OutlineColor
	{
		get
		{
			return (Color)null;
		}
		set
		{
		}
	}

	public float OutlineWidth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Bake()
	{
	}

	private void LoadSmoothNormals()
	{
	}

	private List<Vector3> SmoothNormals(Mesh mesh)
	{
		return null;
	}

	private void UpdateMaterialProperties()
	{
	}
}
