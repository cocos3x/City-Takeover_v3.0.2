using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyChallengeUi : BaseScreenUi
{
	private sealed class _003CITimerText_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyChallengeUi _003C_003E4__this;

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
		public _003CITimerText_003Ed__28(int _003C_003E1__state)
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
	private TMP_Text title;

	[SerializeField]
	private Image customizationRewardIcon;

	[SerializeField]
	private GameObject checkMark;

	[SerializeField]
	private GameObject rewardDescriptionText;

	[SerializeField]
	private GameObject comeBackText;

	[SerializeField]
	private TMP_Text textReward;

	[SerializeField]
	private Transform heartsContainer;

	[SerializeField]
	private Color hearOn;

	[SerializeField]
	private Color hearOff;

	[SerializeField]
	private GameObject playButton;

	[SerializeField]
	private GameObject okButton;

	[SerializeField]
	private TMP_Text playButtonText;

	[SerializeField]
	private GameObject videoContainer;

	[SerializeField]
	private ParticleSystem confetti;

	[SerializeField]
	private TMP_Text timerText;

	[SerializeField]
	private GameObject winFeatureImage;

	[SerializeField]
	private GameObject challengeFeatureImage;

	private GameManager gameManager;

	private DailyChallengesManager dcManager;

	public override void OnOpen()
	{
	}

	private void RefreshScreen()
	{
	}

	public void _OnPressedPlayed()
	{
	}

	public void _OnBackPressed()
	{
	}

	public void _DebugResetState()
	{
	}

	private void RefreshHearts()
	{
	}

	private void RefreshRewards()
	{
	}

	private void AttemptReplenishHearts()
	{
	}

	private bool IsOnLevelScene()
	{
		return false;
	}

	private IEnumerator ITimerText()
	{
		return null;
	}

	private void _003CAttemptReplenishHearts_003Eb__26_0(bool success)
	{
	}
}
