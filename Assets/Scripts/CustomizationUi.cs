using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CustomizationUi : BaseScreenUi
{
	public delegate void d_OnNewItemEquipped();

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Customization c;

		public string id;

		public CustomizationUi _003C_003E4__this;

		public string equippedId;

		internal void _003COnCustomizationButtonClicked_003Eb__0(bool success)
		{
		}
	}

	[SerializeField]
	private GameObject customizationButtonPrefab;

	[SerializeField]
	private Transform buttonsPanel;

	[SerializeField]
	private GameObject freeCoinsButton;

	[SerializeField]
	private TMP_Text freeCoinsButtonText;

	[SerializeField]
	private GameObject buildingTabButton;

	[SerializeField]
	private CustomizationTabButton[] tabButtons;

	private List<CustomizationButton> buttons;

	private GameManager gameManager;

	private CustomizationManager customizationManager;

	private string currentTab;

	private int _freeCoinValue;

	public d_OnNewItemEquipped OnNewItemEquipped;

	public override void OnOpen()
	{
	}

	public void OnTabClicked(string tab)
	{
	}

	private Customization GetCustomizationByName(string s)
	{
		return null;
	}

	public void PopulatePanel(string customizationName)
	{
	}

	public void ClearPanel()
	{
	}

	private void OnCustomizationButtonClicked(CustomizationButton button)
	{
	}

	public void OnBackPressed()
	{
	}

	public void _OnFreeCoinsPressed()
	{
	}

	private void TrackSkinShopOpened()
	{
	}

	private void TrackSkinSelected(Customization _CustomizationType, string _PreviousSkin)
	{
	}

	private void TrackSkinPurchase(Customization _CustomizationType, string _PreviousSkin, bool _RV)
	{
	}

	private void _003C_OnFreeCoinsPressed_003Eb__18_0(bool complete)
	{
	}
}
