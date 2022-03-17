using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Shield : PowerUpBase
{
	private sealed class _003CEffect_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Shield _003C_003E4__this;

		public Building target;

		private float _003Cduration_003E5__2;

		private float _003Ctimer_003E5__3;

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
		public _003CEffect_003Ed__6(int _003C_003E1__state)
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
	private float _ShieldDuration;

	[SerializeField]
	private ParticleSystem _ParticlesOnSpawn;

	[SerializeField]
	private ParticleSystem _ParticlesOnDespawn;

	[SerializeField]
	private GameObject _ShieldRender;

	private float _forcedDuration;

	public override bool AllowedToActivate(Building b)
	{
		return false;
	}

	protected override IEnumerator Effect(Building target)
	{
		return null;
	}

	public override void SetForcedStrength(int strength)
	{
	}

	[DebuggerHidden]
	private IEnumerator _003C_003En__0(Building target)
	{
		return null;
	}
}
