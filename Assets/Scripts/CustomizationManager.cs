using System.Collections.Generic;
using UnityEngine;

public class CustomizationManager : MonoBehaviour
{
	public static CustomizationManager Instance;

	[SerializeField]
	private CustomizationData[] HeadsData;

	[SerializeField]
	private CustomizationData[] BodiesData;

	[SerializeField]
	private CustomizationData[] SwordsData;

	[SerializeField]
	private CustomizationData[] ShiledsData;

	[SerializeField]
	private CustomizationData[] BuildingsData;

	public CustomizationBuildingData[] BuildingsCustomData;

	public Customization HeadCustomization;

	public Customization BodyCustomization;

	public Customization SwordCustomization;

	public Customization ShieldCustomization;

	public Customization BuildingCustomization;

	private List<Customization> AllCustomizations;

	public void Init()
	{
	}

	public Customization GetCustomizationByType(string cType)
	{
		return null;
	}

	public Customization GetRandomCustomization()
	{
		return null;
	}

	public void UpdateRsPrices(CustomizationData[] datas, int[] prices)
	{
	}
}
