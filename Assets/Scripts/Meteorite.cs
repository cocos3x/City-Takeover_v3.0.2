using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Meteorite : PowerUpBase
{
	private sealed class _003CEffect_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Meteorite _003C_003E4__this;

		public Building target;

		private float _003ClerpValue_003E5__2;

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
		public _003CEffect_003Ed__8(int _003C_003E1__state)
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
	private int _Damage;

	[SerializeField]
	private float _FallingSpeed;

	[SerializeField]
	private ParticleSystem _MeteoriteFall;

	[SerializeField]
	private ParticleSystem _MeteoriteImpact;

	[SerializeField]
	private Vector3 _StartZoneOffset;

	[SerializeField]
	private Vector3 _EndZoneOffset;

	private int _forcedDamage;

	public override bool AllowedToActivate(Building b)
	{
		return false;
	}

	protected override IEnumerator Effect(Building target)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
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
