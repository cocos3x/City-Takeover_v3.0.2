using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
	[SerializeField]
	private float minDistance;

	[SerializeField]
	private float maxDistance;

	public Camera cam;

	private float _003CDistanceToTarget_003Ek__BackingField;

	private Vector3 _003CTarget_003Ek__BackingField;

	private Vector3 previousPosition;

	public float DistanceToTarget
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector3 Target
	{
		get
		{
			return (Vector3)null;
		}
		set
		{
		}
	}

	public void CalculateDistanceBasedOnWorldDimensions(int columns, int rows, int depths)
	{
	}

	private void Update()
	{
	}

	private void StartMove(Vector3 screenPosition)
	{
	}

	private void Move(Vector3 screenPosition)
	{
	}

	private void MoveCameraByDirection(Vector3 direction)
	{
	}

	public void RefreshLocation()
	{
	}
}
