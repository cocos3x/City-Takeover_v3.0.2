using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class HazardMeteor : MonoBehaviour
{
	private sealed class _003CEffect_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HazardMeteor _003C_003E4__this;

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

	public int Damage;

	public float FallingSpeed;

	public ParticleSystem FallPS;

	public ParticleSystem ImpactPS;

	public Vector3 StartZoneOffset;

	public Vector3 EndZoneOffset;

	public IEnumerator Effect(Vector3 position, [Optional] Building target)
	{
		return null;
	}
}
