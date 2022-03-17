using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BattleModeLevelCompleteUi : LevelCompleteUi, IBattleLevelComplete
{
	private sealed class _003CShowBattleModeLeaderboardAnimation_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleModeLevelCompleteUi _003C_003E4__this;

		private List<PlayerDescription> _003Cdescriptions_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CShowBattleModeLeaderboardAnimation_003Ed__5(int _003C_003E1__state)
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
	private Transform _playerContainer;

	[SerializeField]
	private BattleModePlayerDescription _playerDescriptionPrefab;

	private BattleModePlayerDescription[] _battleModePlayerDescriptions;

	public override void Init(int level)
	{
	}

	private void RemoveCurrentDescriptions()
	{
	}

	public IEnumerator ShowBattleModeLeaderboardAnimation()
	{
		return null;
	}

	protected override int CalculateCoinsEarned()
	{
		return 0;
	}
}
