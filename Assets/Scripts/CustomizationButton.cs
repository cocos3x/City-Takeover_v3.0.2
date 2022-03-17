using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomizationButton : MonoBehaviour
{
	public delegate void d_OnClicked(CustomizationButton button);

	private bool _003CCanGetByVideoReward_003Ek__BackingField;

	private Customization _003Ccustomization_003Ek__BackingField;

	private string _003Cid_003Ek__BackingField;

	[SerializeField]
	private TMP_Text tmp;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private GameObject videoContainer;

	[SerializeField]
	private GameObject unlockedVisualContainer;

	[SerializeField]
	private GameObject selectedVisualContainer;

	[SerializeField]
	private GameObject priceBackground;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private Sprite backgroundSprite;

	[SerializeField]
	private Sprite giftBackgroundSprite;

	[SerializeField]
	private Color selectedColor;

	public d_OnClicked OnClicked;

	public bool CanGetByVideoReward
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public Customization customization
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string id
	{
		get
		{
			return "";
		}
		private set
		{
		}
	}

	public void Init(string id, Customization c)
	{
	}

	public void TryToMakeItVideoReward()
	{
	}

	public void _Clicked()
	{
	}
}
