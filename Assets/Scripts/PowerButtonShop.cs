using DG.Tweening;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerButtonShop : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public bool rvWatched;

		public PowerButtonShop _003C_003E4__this;

		internal void _003CBuyPower_003Eb__0(bool result)
		{
		}
	}

	private static List<PowerButtonShop> PuShopButtons;

	[SerializeField]
	private Image _Icon;

	[SerializeField]
	private TextMeshProUGUI _Title;

	[SerializeField]
	private TextMeshProUGUI _Price;

	[SerializeField]
	private GameObject[] _LockRenderer;

	[SerializeField]
	private Button _BuyButton;

	[SerializeField]
	private RectTransform _PowerButton;

	[SerializeField]
	private GameObject _LockIcon;

	[SerializeField]
	private GameObject _PriceObject;

	[SerializeField]
	private GameObject _RvButtonObject;

	[SerializeField]
	private TextMeshProUGUI _RvText;

	[SerializeField]
	private TMP_Text _PlusOne;

	private PowerUpData _PuDatas;

	private Sequence plusOneSequence;

	public event Action OnBuy
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateDatas()
	{
	}

	public void SetDatas(PowerUpData datas)
	{
	}

	private void BuyPower()
	{
	}

	private void DoPlusOneAnimation()
	{
	}

	private void TrackPowerUpBought(bool _RVWatched, bool _FSWatched)
	{
	}

	private void _003CDoPlusOneAnimation_003Eb__23_0()
	{
	}
}
