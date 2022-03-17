using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LightSkinShopUi : BaseScreenUi
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LightSkinShopItem> _003C_003E9__10_0;

		internal int _003CDrawItems_003Eb__10_0(LightSkinShopItem sp1, LightSkinShopItem sp2)
		{
			return 0;
		}
	}

	[SerializeField]
	private LightSkinShopItemView shopStandardItemViewPrefab;

	[SerializeField]
	private LightSkinShopItemView shopPremiumItemViewPrefab;

	[SerializeField]
	private LightSkinShopItemView singleItemView;

	[SerializeField]
	private Transform itemsGrid;

	[SerializeField]
	private TextMeshProUGUI _noThanksText;

	private List<LightSkinShopItem> _shopItems;

	private List<LightSkinShopItemView> _shopItemViews;

	public Action callBack;

	public void Start()
	{
	}

	public override void OnOpen()
	{
	}

	public List<LightSkinShopItem> DrawItems()
	{
		return null;
	}

	public void OnPurchase(LightSkinShopItem shopItem)
	{
	}

	public void UnlockAndEquip(LightSkinShopItem shopItem)
	{
	}

	public new void OnClose()
	{
	}
}
