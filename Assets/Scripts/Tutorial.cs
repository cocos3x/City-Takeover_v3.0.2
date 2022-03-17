using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public bool dismissedPopup;

		internal void _003CITutorial_003Eb__0()
		{
		}

		internal void _003CITutorial_003Eb__1()
		{
		}
	}

	private sealed class _003CITutorial_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Tutorial _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

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
		public _003CITutorial_003Ed__6(int _003C_003E1__state)
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
	private TutorialHand hand;

	[SerializeField]
	private GameObject obstacle;

	[SerializeField]
	private Building building0;

	[SerializeField]
	private Building building1;

	private GameUi ui;

	public void StartTutorial(GameUi gameUi)
	{
	}

	private IEnumerator ITutorial()
	{
		return null;
	}

	private bool HasConnection(Building b)
	{
		return false;
	}

	private bool IsBuildingBlue(Building b)
	{
		return false;
	}

	public void EndTutorial()
	{
	}
}
