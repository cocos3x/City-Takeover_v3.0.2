using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Voodoo.Sauce.Internal.CrossPromo.Utils
{
	public class CoroutineQueue
	{
		private sealed class _003CProcess_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoroutineQueue _003C_003E4__this;

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
			public _003CProcess_003Ed__7(int _003C_003E1__state)
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

		private readonly MonoBehaviour _owner;

		private Coroutine _internalCoroutine;

		private readonly Queue<IEnumerator> _actions;

		public CoroutineQueue(MonoBehaviour owner)
		{
		}

		private void StartLoop()
		{
		}

		private void StopLoop()
		{
		}

		public void EnqueueAction(IEnumerator action)
		{
		}

		private IEnumerator Process()
		{
			return null;
		}
	}
}
