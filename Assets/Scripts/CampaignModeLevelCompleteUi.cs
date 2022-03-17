using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CampaignModeLevelCompleteUi : LevelCompleteUi, ICampaignLevelComplete
{
	private sealed class _003CShowRegionProgressAnimation_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampaignModeLevelCompleteUi _003C_003E4__this;

		private int _003Clevel_003E5__2;

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
		public _003CShowRegionProgressAnimation_003Ed__7(int _003C_003E1__state)
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
	private TMP_Text levelText;

	[SerializeField]
	private RegionProgressUi regionProgress;

	[SerializeField]
	private Transform bear;

	[SerializeField]
	private GameObject starsContainer;

	[SerializeField]
	private Image[] emptyStars;

	[SerializeField]
	private Image[] fullStars;

	public override void Init(int level)
	{
	}

	public IEnumerator ShowRegionProgressAnimation()
	{
		return null;
	}

	public void ShowCrownCollectionAnimation()
	{
	}

	protected override int CalculateCoinsEarned()
	{
		return 0;
	}

	public void ShowLevelTextAnimation()
	{
	}

	public void ShowBearAnimation()
	{
	}

	private void _003CShowRegionProgressAnimation_003Eb__7_0()
	{
	}
}
