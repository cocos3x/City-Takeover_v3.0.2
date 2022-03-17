using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class SearchOpponentView : BaseScreenUi
{
	private sealed class _003CCheckPing_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<bool> _Callback;

		private float _003Ctimeout_003E5__2;

		private float _003CelapsedTime_003E5__3;

		private Ping _003Cping_003E5__4;

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
		public _003CCheckPing_003Ed__6(int _003C_003E1__state)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PlayerDescription, bool> _003C_003E9__8_0;

		internal bool _003COpenView_003Eb__8_0(PlayerDescription description)
		{
			return false;
		}
	}

	private sealed class _003COpenView_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SearchOpponentView _003C_003E4__this;

		public PlayerDescription[] _Descriptions;

		public Action _Callback;

		private float _003CwaitTime_003E5__2;

		private float _003CelapsedTime_003E5__3;

		private float _003CframeTime_003E5__4;

		private float _003CskipFrameTime_003E5__5;

		private float _003CopponentFoundTargetTime_003E5__6;

		private int _003CdotCount_003E5__7;

		private List<PlayerDescription> _003Cdescriptions_003E5__8;

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
		public _003COpenView_003Ed__8(int _003C_003E1__state)
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
	private TMP_Text _searchText;

	[SerializeField]
	private RectTransform _descriptionContainer;

	[SerializeField]
	private GameObject _OkButton;

	[SerializeField]
	private BattleModePlayerDescription _battleModePlayerDescriptioPrefab;

	private List<BattleModePlayerDescription> _playerDescriptions;

	public void InitializeSearch(PlayerDescription[] _Descriptions, [Optional] Action _Callback)
	{
	}

	private IEnumerator CheckPing(Action<bool> _Callback)
	{
		return null;
	}

	private void RemovePlayerDescriptions()
	{
	}

	private IEnumerator OpenView(PlayerDescription[] _Descriptions, Action _Callback)
	{
		return null;
	}

	private void GenerateDescriptionView(PlayerDescription _Description)
	{
	}

	public void OnOkButtonPressed()
	{
	}
}
