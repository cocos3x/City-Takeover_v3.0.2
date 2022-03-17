using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class SettingsUi : BaseScreenUi
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public SettingsUi _003C_003E4__this;

		public TutorialUi ui;

		public int i;

		internal void _003CI_OnTutorialReturned_003Eb__0()
		{
		}
	}

	private sealed class _003CI_OnTutorialReturned_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SettingsUi _003C_003E4__this;

		public TutorialUi ui;

		public int i;

		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

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
		public _003CI_OnTutorialReturned_003Ed__17(int _003C_003E1__state)
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
	private TMP_Text musicText;

	[SerializeField]
	private TMP_Text sfxText;

	[SerializeField]
	private TMP_Text vibrationText;

	[SerializeField]
	private GameObject gdprButton;

	[SerializeField]
	private GameObject restoreButton;

	[SerializeField]
	private GameObject restoreLoader;

	private string onString;

	private string offString;

	public override void OnOpen()
	{
	}

	public void _OnClose()
	{
	}

	public void _OnSFXToggle()
	{
	}

	public void _OnMusicToggle()
	{
	}

	public void _OnVibrationToggle()
	{
	}

	public void _OnGDPRPressed()
	{
	}

	public void _OnHowToPressed()
	{
	}

	public void _OnRestorePurchasePressed()
	{
	}

	public void OnTutorialReturned(TutorialUi ui, int i)
	{
	}

	private IEnumerator I_OnTutorialReturned(TutorialUi ui, int i)
	{
		return null;
	}

	private void UpdateAudioText()
	{
	}

	private void UpdateVibrationText()
	{
	}

	private void TrackHowToPlayPressed()
	{
	}

	private void _003COnOpen_003Eb__8_0(bool isApplicable)
	{
	}

	private void _003C_OnRestorePurchasePressed_003Eb__15_0(RestorePurchasesResult result)
	{
	}
}
