using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
	private sealed class _003CEffect_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CEffect_003Ed__3(int _003C_003E1__state)
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

	protected Coroutine _EffectCoroutine;

	public virtual void PlayEffect(Building target)
	{
	}

	public virtual bool AllowedToActivate(Building b)
	{
		return false;
	}

	protected virtual IEnumerator Effect(Building target)
	{
		return null;
	}

	private void ResetCoroutine()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void SetForcedStrength(int strength)
	{
	}
}
