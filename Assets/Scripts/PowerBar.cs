using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PowerBar : MonoBehaviour
{
	private sealed class _003CFadeOnBar_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerBar _003C_003E4__this;

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
		public _003CFadeOnBar_003Ed__15(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string powerId;

		internal bool _003CGetButton_003Eb__0(PowerButton button)
		{
			return false;
		}
	}

	[SerializeField]
	private RectTransform _PuContainer;

	[SerializeField]
	private PowerButton _PuButton;

	[SerializeField]
	private float _FadingSpeed;

	[SerializeField]
	private AnimationCurve _FadingCurve;

	[SerializeField]
	private float _BannerMargin;

	[SerializeField]
	private RectTransform _RectTransform;

	[SerializeField]
	private CanvasGroup _CanvasGroup;

	[SerializeField]
	private bool _IsShopBar;

	private List<PowerButton> _PowerButtons;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void CreatePowerUpButtons()
	{
	}

	private void Register()
	{
	}

	private void ClearContainer()
	{
	}

	private bool SetupContainer()
	{
		return false;
	}

	private IEnumerator FadeOnBar()
	{
		return null;
	}

	private void AdaptWithBanner()
	{
	}

	public PowerButton GetButton(string powerId)
	{
		return null;
	}

	public void Hide()
	{
	}

	public void UpdateAllButton()
	{
	}
}
