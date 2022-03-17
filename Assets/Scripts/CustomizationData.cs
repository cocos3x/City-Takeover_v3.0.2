using System;
using UnityEngine;

[Serializable]
public struct CustomizationData
{
	public string name;

	public CurrencyType currency;

	public int price;

	public Sprite icon;

	public bool hideInStore;
}
