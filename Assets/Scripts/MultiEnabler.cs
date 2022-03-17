using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MultiEnabler : MonoBehaviour
{
	[Serializable]
	public struct EnableableGO
	{
		public GameObject gameObject;

		public float delay;
	}

	private sealed class _003C_EnableGOsCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultiEnabler _003C_003E4__this;

		private List<EnableableGO>.Enumerator _003C_003E7__wrap1;

		private EnableableGO _003CgameObjectsToEnable_003E5__3;

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
		public _003C_EnableGOsCoroutine_003Ed__9(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public bool deactivateObjsAtStart;

	public bool deactivateObjsWhenDeactivated;

	public List<EnableableGO> gameObjectsToEnableList;

	private Coroutine _EnableGOsCoroutineInstance;

	public void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void DeactivateAllObjects()
	{
	}

	private IEnumerator _EnableGOsCoroutine()
	{
		return null;
	}
}
