using TMPro;
using UnityEngine;

public class IAPButtonVisual : MonoBehaviour
{
	public delegate void d_OnClicked(IAPButtonVisual button);

	private string _003CIAP_ID_003Ek__BackingField;

	[SerializeField]
	private TMP_Text title;

	[SerializeField]
	private TMP_Text price;

	[SerializeField]
	private GameObject purchasedContainer;

	private string description;

	public d_OnClicked OnClicked;

	public string IAP_ID
	{
		get
		{
			return "";
		}
		private set
		{
		}
	}

	public string TitleLabel => "";

	public void Init(string title, string description, string iapId)
	{
	}

	public void _OnInfoClicked()
	{
	}

	public void _OnClicked()
	{
	}

	public void SetPurcahsed(bool purchased)
	{
	}
}
