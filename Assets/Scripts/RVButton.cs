using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class RVButton : MonoBehaviour
{
	public enum RVButtonStatusEnum
	{
		Idle,
		RVLoading,
		RVShowing,
		RVError
	}

	private sealed class _003C_RetryCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RVButton _003C_003E4__this;

		private GameObject _003CnoNetworkFeedbackGO_003E5__2;

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
		public _003C_RetryCoroutine_003Ed__30(int _003C_003E1__state)
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

	private RVButtonStatusEnum _003Cstatus_003Ek__BackingField;

	public Button button;

	public string rvType;

	public Action<bool> onRVCompleteCallBack;

	public Action onAdStartedCallBack;

	public GameObject LoadingImagePrefab;

	public GameObject NetworkErrorPrefab;

	public bool isFree;

	public bool fsAlwaysReplacesRV;

	public bool canDowngradeToFs;

	public float loadingImageScale;

	public Vector2 loadingImageAchor;

	public float loadingImageRotationSpeed;

	public float reattemptDelay;

	public int reattemptNb;

	public float errorStateDuration;

	public float delayToConfirmButtonShown;

	private Image _buttonLoadingRV;

	private int _currentReattempt;

	private Coroutine _retryCoroutineInstance;

	private float _RVShownConfirmCountdown;

	private bool _RVButtonShownEventSent;

	public RVButtonStatusEnum status
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (RVButtonStatusEnum)null;
		}
		private set
		{
		}
	}

	public void Start()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	public void OnClick()
	{
	}

	private IEnumerator _RetryCoroutine()
	{
		return null;
	}

	public void Update()
	{
	}

	private void _OnRVCompleted(bool success)
	{
	}

	private void _003COnClick_003Eb__29_0()
	{
	}

	private void _003C_RetryCoroutine_003Eb__30_0()
	{
	}

	private void _003C_RetryCoroutine_003Eb__30_1()
	{
	}
}
