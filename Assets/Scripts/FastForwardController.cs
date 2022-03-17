using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class FastForwardController : MonoBehaviour
{
	private sealed class _003CupdateCallToActionCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FastForwardController _003C_003E4__this;

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
		public _003CupdateCallToActionCoroutine_003Ed__14(int _003C_003E1__state)
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
	private Animator fastForwardAnimator;

	[SerializeField]
	private ParticleSystem speedLinesPS;

	[SerializeField]
	private TextMeshProUGUI priceTMPro;

	private bool _isFastForwardPurchased;

	private bool _isFastForwardActive;

	private Coroutine _updateCallToActionCoroutineInstance;

	private float _MORE_BUILDING_FACTOR;

	private float _MORE_FLOORS_FACTOR;

	public void Awake()
	{
	}

	public void Init(int level)
	{
	}

	public void OnEnable()
	{
	}

	public void OnFastForwardButtonPressed()
	{
	}

	public void OnLevelComplete()
	{
	}

	public void SetFastForwardActive(bool active)
	{
	}

	public IEnumerator updateCallToActionCoroutine()
	{
		return null;
	}
}
