using UnityEngine;

public class WaterBody : MonoBehaviour
{
	[SerializeField]
	private bool customSurfaceLevel;

	[SerializeField]
	private float surfaceLevel;

	private Collider coll;

	private void Start()
	{
	}

	public float GetYBound()
	{
		return 0f;
	}
}
