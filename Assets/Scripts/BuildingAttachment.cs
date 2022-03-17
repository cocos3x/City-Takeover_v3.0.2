using UnityEngine;

public class BuildingAttachment : MonoBehaviour
{
	internal Building attachedBuilding;

	public void AttachTo(Building b)
	{
	}

	internal virtual void OnAttached(Building b)
	{
	}

	internal void ResizeToMatchHeight(float extraScaleHeight = 0f, float extraMoveHeight = 0f)
	{
	}
}
