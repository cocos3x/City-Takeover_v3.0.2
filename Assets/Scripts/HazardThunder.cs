using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class HazardThunder : MonoBehaviour
{
	private sealed class _003CEffect_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HazardThunder _003C_003E4__this;

		public Building target;

		private int _003Cn_003E5__2;

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
		public _003CEffect_003Ed__9(int _003C_003E1__state)
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

	public int DamagePerHit;

	public int NumberHit;

	public ParticleSystem ImpactPS;

	private bool _003CIsFinished_003Ek__BackingField;

	private Vector3 _originScale;

	public bool IsFinished
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public void Awake()
	{
	}

	public IEnumerator Effect([Optional] Building target)
	{
		return null;
	}
}
