using UnityEngine;

public class CustomizationTabButton : MonoBehaviour
{
	public string customizationType;

	[SerializeField]
	private GameObject selectedContainer;

	[SerializeField]
	private GameObject unselectedContainer;

	public void SetSelected(bool selected)
	{
	}

	public void _OnClick()
	{
	}
}
