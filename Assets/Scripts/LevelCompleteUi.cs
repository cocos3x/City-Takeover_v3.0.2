using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class LevelCompleteUi : BaseScreenUi
{
	private sealed class _003CIOpen_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelCompleteUi _003C_003E4__this;

		private ICampaignLevelComplete _003CcampaignLevelComplete_003E5__2;

		private IBattleLevelComplete _003CbattleLevelComplete_003E5__3;

		private int _003CfromCoins_003E5__4;

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
		public _003CIOpen_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		private sealed class _003C_003CICoinMultiplierClicked_003Eg__DelayedEnd_007C0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public _003C_003Ec__DisplayClass25_0 _003C_003E4__this;

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
			public _003C_003CICoinMultiplierClicked_003Eg__DelayedEnd_007C0_003Ed(int _003C_003E1__state)
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

		public LevelCompleteUi _003C_003E4__this;

		public int coinsToAdd;

		public int currentCoins;

		internal IEnumerator _003CICoinMultiplierClicked_003Eg__DelayedEnd_007C0()
		{
			return null;
		}

		internal void _003CICoinMultiplierClicked_003Eg__OnCoinEarned_007C1()
		{
		}

		internal void _003CICoinMultiplierClicked_003Eg__OnCoinMissed_007C2()
		{
		}

		internal void _003CICoinMultiplierClicked_003Eb__3(bool success)
		{
		}
	}

	private sealed class _003CICoinMultiplierClicked_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelCompleteUi _003C_003E4__this;

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
		public _003CICoinMultiplierClicked_003Ed__25(int _003C_003E1__state)
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
	private TMP_Text rewardText;

	[SerializeField]
	private TMP_Text rewardBonusWinStreakText;

	[SerializeField]
	private TMP_Text noThanksText;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private ParticleSystem confetti;

	[SerializeField]
	private RVClaimButton button;

	[SerializeField]
	private GameObject adButtonContent;

	[SerializeField]
	private GameObject noThanksButton;

	[SerializeField]
	protected MultiplierMeter meter;

	[SerializeField]
	private MenuButtonLayout menuButtonHandler;

	[SerializeField]
	private WinStreakAdvancementUI WinStreakUI;

	protected GameManager gameManager;

	private bool showMultiplier;

	private bool buttonClicked;

	private int coinsEarned;

	private bool clickedCoinMultiplierButton;

	private int _completedLevel;

	private Coroutine IOpen_coroutineInstance;

	private bool _rvMultiplierShown;

	private int _totalCoinsEarned;

	private void Awake()
	{
	}

	public virtual void Init(int level)
	{
	}

	public override void OnOpen()
	{
	}

	protected IEnumerator IOpen()
	{
		return null;
	}

	protected abstract int CalculateCoinsEarned();

	private IEnumerator ICoinMultiplierClicked()
	{
		return null;
	}

	public void _OnGreenButtonClicked()
	{
	}

	public void _OnMenuButtonClicked()
	{
	}

	public void _OnNoThanksClicked()
	{
	}

	private void _ShowRNG_displayLightSkinShop_AndExit()
	{
	}

	private void _OnDisplayLightSkinShop()
	{
	}

	private void ExitScreen()
	{
	}

	public int CalculateCoinsFromMeter()
	{
		return 0;
	}

	private void TrackRVCoinsMultiplier(float _CoinsEarned)
	{
	}

	private void TrackFinishMenu()
	{
	}
}
