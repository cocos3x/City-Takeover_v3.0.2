using UnityEngine;

public class LineRendererAnchors : MonoBehaviour
{
	[SerializeField]
	private LineRenderer line;

	[SerializeField]
	private Transform from;

	[SerializeField]
	private Transform to;

	[SerializeField]
	private Vector3 offset;

	private void LateUpdate()
	{
	}
}
