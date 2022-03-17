using TMPro;
using UnityEngine;

public class IncrementalController : MonoBehaviour
{
	public const string INCREMENTAL_STARTFLOORS_LEVEL_KEY = "INCREMENTAL_STARTFLOORS_LEVEL";

	public GameObject IncreaseStartFloors_Container;

	public RVButton IncreaseStartFloors_RVButton;

	public GameObject IncreaseStartFloors_rvCostGameObj;

	public TextMeshProUGUI IncreaseStartFloors_AmountText;

	public TextMeshProUGUI IncreaseStartFloors_CostText;

	public GameObject IncreaseStartFloors_banner;

	public GameObject IncreaseStartFloors_FX;

	private int _003CStartFloorsLevel_003Ek__BackingField;

	private int _003CStartFloorsAmount_003Ek__BackingField;

	public int StartFloorsLevel
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int StartFloorsAmount
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void OnEnable()
	{
	}

	public void IncreaseStartFloors_RVCallback(bool completed)
	{
	}

	public void IncreaseStartFloors_CannotPurchaseAnim()
	{
	}

	public void IncreaseStartFloors_LevelUp()
	{
	}

	public void IncreaseStartFloors_RefreshButtonLook()
	{
	}
}
