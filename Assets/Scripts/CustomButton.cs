using UnityEngine;

public class CustomButton : MonoBehaviour
{
	[SerializeField]
	private RectTransform top;

	[SerializeField]
	private RectTransform bottom;

	private bool _003CInteractible_003Ek__BackingField;

	private Vector3 startingTopLocalPos;

	private bool initialized;

	public bool Interactible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Init()
	{
	}

	private void OnEnable()
	{
	}

	public void Down()
	{
	}

	public void Up()
	{
	}
}
