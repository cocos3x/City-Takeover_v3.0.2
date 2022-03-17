using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Onboarding : MonoBehaviour
{
	[Serializable]
	public struct HandControllerDatas
	{
		public float handSpeed;

		public Vector3 handPosition;

		public Vector3[] handMove;

		public void UpdateData(TutorialHand hand, bool restartOnSet = true)
		{
		}
	}

	private sealed class _003CIOnboarding_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CIOnboarding_003Ed__16(int _003C_003E1__state)
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

	private int onboardingPopupCount;

	[SerializeField]
	protected HandControllerDatas[] handDatas;

	[SerializeField]
	private TutorialStep tutorialStep;

	protected TutorialHand hand;

	protected GameUi ui;

	protected Coroutine onboardingCoroutine;

	protected TextMeshProUGUI titleText;

	protected Button helpButton;

	public int OnboardingCount => 0;

	protected TutorialStep TutorialStep
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (TutorialStep)null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void StartOnboarding()
	{
	}

	protected virtual IEnumerator IOnboarding()
	{
		return null;
	}

	public void StopOnboarding()
	{
	}

	protected void OpenTutorial()
	{
	}

	protected void UpdateTitle()
	{
	}
}
