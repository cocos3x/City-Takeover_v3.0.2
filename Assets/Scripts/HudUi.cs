using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HudUi : BaseScreenUi
{
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public float previousVolume;

		internal void _003CIFreezeRoutine_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003CIFreezeRoutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

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
		public _003CIFreezeRoutine_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CICountDown_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudUi _003C_003E4__this;

		public Action callback;

		private WaitForSeconds _003Csecond_003E5__2;

		private string _003CstartText_003E5__3;

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
		public _003CICountDown_003Ed__38(int _003C_003E1__state)
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
	private GameObject fillGameObject;

	[SerializeField]
	private Image blueFill;

	[SerializeField]
	private Image redFill;

	[SerializeField]
	private Image greenFill;

	[SerializeField]
	private Image yellowFill;

	[SerializeField]
	private Image freezeTimer;

	[SerializeField]
	private GameObject freezeButton;

	[SerializeField]
	private TMP_Text movieCountDown;

	[SerializeField]
	private GameObject collectCrownsInstructionContainer;

	[SerializeField]
	private ParticleSystem confetti;

	[SerializeField]
	private PowerBar powerUpBar;

	[SerializeField]
	private GameObject centeredLevelComplete;

	[SerializeField]
	private RectTransform battleModeCrown;

	[SerializeField]
	public FastForwardController fastForwardController;

	[SerializeField]
	private HazardInfoUI hazardInfo;

	private float blueFillTarget;

	private float redFillTarget;

	private float greenFillTarget;

	private float yellowFillTarget;

	private float firstPlayerFillStartValue;

	private float firstPlayerFillEndValue;

	private bool animateRed;

	private bool animateGreen;

	private GameManager manager;

	private void Awake()
	{
	}

	public void Init(int level)
	{
	}

	public override void OnOpen()
	{
	}

	public void UpdateFill(Dictionary<BuildingTeam, int> fillMap, int totalCount)
	{
	}

	private void CheckFillValue(float[] fillValues)
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateCrownPosition()
	{
	}

	public void ShowFreezeButton(bool show)
	{
	}

	public void _OnFreezeButtonPressed()
	{
	}

	public void _OnBackButtonPressed()
	{
	}

	public bool IsFreezeButtonShowing()
	{
		return false;
	}

	private IEnumerator IFreezeRoutine()
	{
		return null;
	}

	public void StartMovieCountDown([Optional] Action callback)
	{
	}

	private IEnumerator ICountDown([Optional] Action callback)
	{
		return null;
	}

	public void ShowLevelComplete(bool showCrownText)
	{
	}

	public void ShowCenteredLevelComplete(bool show)
	{
	}

	public void PlayConfetti()
	{
	}

	private void _003CShowFreezeButton_003Eb__32_0()
	{
	}
}
