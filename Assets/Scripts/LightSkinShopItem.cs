using UnityEngine;

public class LightSkinShopItem
{
	public string type;

	public string id;

	public int price;

	public Sprite sprite;

	public bool isPremium;

	public bool useRV;

	public bool useTimer;

	public LightSkinShopItem(string p_type, string p_id, int p_price, Sprite p_sprite)
	{
	}

	public int RebatePrice()
	{
		return 0;
	}
}
