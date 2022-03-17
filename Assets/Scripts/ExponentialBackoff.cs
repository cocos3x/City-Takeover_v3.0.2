using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ExponentialBackoff : MonoBehaviour
{
	public class ExpBackoff
	{
		public float[] Delays;

		public Action Callback;

		public string Name;

		private Coroutine _coroutine;

		private int _currentDelayIndex;

		public void Start()
		{
		}

		public void Reset()
		{
		}

		private void Stop()
		{
		}

		private void _003CStart_003Eb__6_0()
		{
		}
	}

	private sealed class _003CBackoffCoroutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string name;

		public float delay;

		public Action callback;

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
		public _003CBackoffCoroutine_003Ed__5(int _003C_003E1__state)
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

	private const string TAG = "ExponentialBackoff";

	private static ExponentialBackoff _instance;

	private void Awake()
	{
	}

	public static ExpBackoff CreateExpBackoff(Action callback, string name)
	{
		return null;
	}

	private static IEnumerator BackoffCoroutine(float delay, Action callback, string name)
	{
		return null;
	}
}
