using System.Collections.Generic;
using UnityEngine;

public class Customization
{
	private string _003CcustomizationType_003Ek__BackingField;

	private string equippedId;

	private Dictionary<string, CustomizationItem> items;

	private Dictionary<string, CustomizationData> itemsData;

	private List<string> ownedIds;

	private List<string> allIds;

	public string customizationType
	{
		get
		{
			return "";
		}
		private set
		{
		}
	}

	public string EquippedId
	{
		get
		{
			return "";
		}
		private set
		{
		}
	}

	public Customization(string ctype, string defaultId, CustomizationData[] customizationDatas)
	{
	}

	public void Equip(string id)
	{
	}

	public void Unlock(string id)
	{
	}

	public string[] GetAllItems()
	{
		return null;
	}

	public CustomizationItem GetCustomizationItemResource(string id)
	{
		return null;
	}

	public bool Owns(string id)
	{
		return false;
	}

	public bool CanAfford(string id)
	{
		return false;
	}

	public bool CanAfford(string id, int currencyAmount)
	{
		return false;
	}

	public int GetPrice(string id)
	{
		return 0;
	}

	public Sprite GetIcon(string id)
	{
		return null;
	}

	public bool HideInStore(string id)
	{
		return false;
	}

	public CurrencyType GetCurrencyType(string id)
	{
		//IL_0003: Expected I4, but got O
		return (CurrencyType)null;
	}

	public string GetRandomSkin()
	{
		return "";
	}

	public string GetRandomItem()
	{
		return "";
	}

	public string GetRandomUnownedItem()
	{
		return "";
	}

	public void DEBUG_UnlockAll()
	{
	}
}
