using UnityEngine;

public class BuildingAttachmentIce : BuildingAttachment
{
	[SerializeField]
	private ParticleSystem particle;

	internal override void OnAttached(Building b)
	{
	}

	public void PlayParticle()
	{
	}

	public void StopParticle()
	{
	}

	private void OnBuildingResized(Building b)
	{
	}

	private void OnDestroy()
	{
	}
}
