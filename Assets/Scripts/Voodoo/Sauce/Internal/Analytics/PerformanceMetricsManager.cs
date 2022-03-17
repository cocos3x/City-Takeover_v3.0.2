using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class PerformanceMetricsManager
	{
		private sealed class _003CPerformanceMetricsCoroutine_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float period;

			public PerformanceMetricsManager _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private List<float> _003CframeLengths_003E5__3;

			private List<long> _003CmemoryUsages_003E5__4;

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
			public _003CPerformanceMetricsCoroutine_003Ed__1(int _003C_003E1__state)
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

		public static void Initialize(float period)
		{
		}

		private IEnumerator PerformanceMetricsCoroutine(float period)
		{
			return null;
		}

		private void SendPerformanceMetricsEvent(List<float> frameLengths, List<long> memoryUsages)
		{
		}
	}
}
