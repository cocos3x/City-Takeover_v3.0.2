using UnityEngine;

public class PeepUi : MonoBehaviour
{
	public string peepId;

	[SerializeField]
	private Transform peepImage;

	[SerializeField]
	private Transform peepJumpTransform;

	[SerializeField]
	private bool autoRefreshOnEnable;

	private void OnEnable()
	{
	}

	public void Refresh()
	{
	}
}
