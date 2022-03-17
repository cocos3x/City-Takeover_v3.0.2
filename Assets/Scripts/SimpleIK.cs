using UnityEngine;

public class SimpleIK : MonoBehaviour
{
	public int ChainLength;

	public Transform Target;

	public Transform Pole;

	public int Iterations;

	public float Delta;

	public float SnapBackStrength;

	protected float[] BonesLength;

	protected float CompleteLength;

	protected Transform[] Bones;

	protected Vector3[] Positions;

	protected Vector3[] StartDirectionSucc;

	protected Quaternion[] StartRotationBone;

	protected Quaternion StartRotationTarget;

	protected Transform Root;

	private void Awake()
	{
	}

	private void Init()
	{
	}

	private void LateUpdate()
	{
	}

	private void ResolveIK()
	{
	}

	private Vector3 GetPositionRootSpace(Transform current)
	{
		return (Vector3)null;
	}

	private void SetPositionRootSpace(Transform current, Vector3 position)
	{
	}

	private Quaternion GetRotationRootSpace(Transform current)
	{
		return (Quaternion)null;
	}

	private void SetRotationRootSpace(Transform current, Quaternion rotation)
	{
	}
}
