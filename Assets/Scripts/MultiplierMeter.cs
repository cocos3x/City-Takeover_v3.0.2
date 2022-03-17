using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class MultiplierMeter : MonoBehaviour
{
	private sealed class _003CIGO_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultiplierMeter _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003Cspeed_003E5__3;

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
		public _003CIGO_003Ed__5(int _003C_003E1__state)
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
	private TMP_Text[] multipliers;

	[SerializeField]
	private Transform arrow;

	private float t;

	public void Go()
	{
	}

	public void Stop()
	{
	}

	private IEnumerator IGO()
	{
		return null;
	}

	private void UpdateMultiplierScale()
	{
	}

	public float GetMultiplier()
	{
		return 0f;
	}
}
