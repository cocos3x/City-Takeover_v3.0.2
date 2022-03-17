using UnityEngine;

public class BuildingMid : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer rend;

	[SerializeField]
	private MeshRenderer windowRend;

	[SerializeField]
	private ParticleSystem bricks;

	public void SetMaterial(Material mat, Material windowMat)
	{
	}

	public Vector3 GetTopPosition()
	{
		return (Vector3)null;
	}

	public void Kill(bool playParticle)
	{
	}

	public void PlayBricks()
	{
	}

	private void OnDestroy()
	{
	}
}
