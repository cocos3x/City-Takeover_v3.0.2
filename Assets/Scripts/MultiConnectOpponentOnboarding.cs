using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MultiConnectOpponentOnboarding : Onboarding
{
	private sealed class _003CIOnboarding_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultiConnectOpponentOnboarding _003C_003E4__this;

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
		public _003CIOnboarding_003Ed__6(int _003C_003E1__state)
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
	private Building buildingToConnect;

	[SerializeField]
	private Building buildingMultiConnect;

	[SerializeField]
	private Building buildingOpponent1;

	[SerializeField]
	private Building buildingOpponent2;

	[SerializeField]
	private GameObject obstacle1;

	[SerializeField]
	private GameObject obstacle2;

	protected override IEnumerator IOnboarding()
	{
		return null;
	}
}
