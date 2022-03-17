using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class RVClaimButton : MonoBehaviour
{
	private sealed class _003CIUpdateMultiplierTextLoop_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RVClaimButton _003C_003E4__this;

		private string _003CclaimStr_003E5__2;

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
		public _003CIUpdateMultiplierTextLoop_003Ed__9(int _003C_003E1__state)
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
	private TMP_Text buttonText;

	private GameManager _gameManager;

	private GameUi _gameUI;

	private MultiplierMeter _meter;

	private int _coinsEarned;

	private Coroutine IUpdateMultiplierTextLoop_CoroutineInstance;

	private void Awake()
	{
	}

	public void Init(MultiplierMeter _Meter)
	{
	}

	public void ProcessMultiplierTextLoop(int _CoinsEarned)
	{
	}

	private IEnumerator IUpdateMultiplierTextLoop()
	{
		return null;
	}

	public int CalculateCoinsFromMeter()
	{
		return 0;
	}

	public void UpdateLoc()
	{
	}
}
