using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LightSkinShopItemView : MonoBehaviour
{
	private sealed class _003CUpdateRemainingTimecoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LightSkinShopItemView _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateRemainingTimecoroutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[SerializeField]
	private Image _shopItemIcon;

	[SerializeField]
	private GameObject _timerContainer;

	[SerializeField]
	private TextMeshProUGUI _timerText;

	[SerializeField]
	private TextMeshProUGUI _fullPriceText;

	[SerializeField]
	private TextMeshProUGUI _rebatePriceText;

	[SerializeField]
	public Button _softCurencyButton;

	[SerializeField]
	public RVButton _RVButton;

	private Action<LightSkinShopItem> _onPurchase;

	private Action _onClose;

	private int _remainingSeconds;

	private Coroutine _UpdateRemainingTimecoroutineInstance;

	private LightSkinShopItem _003CshopItem_003Ek__BackingField;

	public LightSkinShopItem shopItem
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public void Start()
	{
	}

	public void SetShopItem(LightSkinShopItem p_shopItem, Action<LightSkinShopItem> onPurchase, Action onClose)
	{
	}

	public void OnRVCompleteCallBack(bool complete)
	{
	}

	public void OnSoftCurrencyButtonClick()
	{
	}

	public IEnumerator UpdateRemainingTimecoroutine()
	{
		return null;
	}

	public void StopTimer()
	{
	}
}
