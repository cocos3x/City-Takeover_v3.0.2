using UnityEngine;

public class Buoyancy : MonoBehaviour
{
	[SerializeField]
	private float buoyantForce;

	[SerializeField]
	private float depthPower;

	[SerializeField]
	private float offsetY;

	private Rigidbody rb;

	private Collider coll;

	private float yBound;

	private void Start()
	{
	}

	private void OnTriggerStay(Collider water)
	{
	}
}
