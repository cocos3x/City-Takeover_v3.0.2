using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;

public class ShopUi : BaseScreenUi, IPurchaseDelegate
{
	private sealed class _003CIDailyCoinsRefresh_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopUi _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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
		public _003CIDailyCoinsRefresh_003Ed__22(int _003C_003E1__state)
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
	private GameObject spinner;

	[SerializeField]
	private GameObject container;

	[SerializeField]
	private IAPButtonVisual noAdsButton;

	[SerializeField]
	private IAPButtonVisual dailyCoinsButton;

	[SerializeField]
	private IAPButtonVisual noAdsDailyCoinsButton;

	[SerializeField]
	private GameObject claimDailyCoinsButton;

	[SerializeField]
	private TMP_Text dailyCoinsButtonText;

	[SerializeField]
	private ParticleSystem confetti;

	private bool firstOpen;

	private bool correctlyInitialized;

	private Coroutine dailyRefreshCoroutine;

	public void OnInitializeFailure(InitializationFailureReason reason)
	{
	}

	public void OnInitializeSuccess()
	{
	}

	public void OnInitializeFailure(VoodooInitializationFailureReason reason)
	{
	}

	public override void OnOpen()
	{
	}

	public void OnPurchaseComplete(string productId)
	{
	}

	public void OnPurchaseFailure(string productId, VoodooPurchaseFailureReason reason, string transactionId)
	{
	}

	public void OnPurchaseFailure(string productId, PurchaseFailureReason reason)
	{
	}

	public void _OnClose()
	{
	}

	public void _OnPurchaseButtonPressed(IAPButtonVisual button)
	{
	}

	private void ShowSpinner(bool show)
	{
	}

	private void RefreshButtons()
	{
	}

	private IEnumerator IDailyCoinsRefresh()
	{
		return null;
	}

	public void _OnClaimFreeCoinsPressed()
	{
	}

	private void TrackIAPShopOpen()
	{
	}

	private void TrackIAPBundlePurchased(string _TitleLabel)
	{
	}

	private void TrackIAPBundleClaimed(int _Coins)
	{
	}
}
