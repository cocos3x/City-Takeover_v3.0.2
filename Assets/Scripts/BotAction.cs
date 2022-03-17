using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class BotAction
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public BuildingTeam _Team;

		public Predicate<Building> _003C_003E9__0;

		internal bool _003CBrainLoop_003Eb__0(Building building)
		{
			return false;
		}
	}

	private sealed class _003CBrainLoop_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BuildingTeam _Team;

		public BotAction _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

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
		public _003CBrainLoop_003Ed__6(int _003C_003E1__state)
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

	private Vector2 decisionMakingTimeRange;

	private Vector2 startDecisionMakingTimeRange;

	private int decisionCapacity;

	protected List<(Building, Building)> _availableConnections;

	protected List<(Building, Building)> _availableDisconnections;

	public virtual void Init(BotActionConfig _ActionConfig)
	{
	}

	public IEnumerator BrainLoop(BuildingTeam _Team)
	{
		return null;
	}

	private void CheckConnectionsAndDisconnections(Building _Building, Building _BuildingInReach)
	{
	}

	protected abstract void PickDecision();

	protected void DebugLog(string s)
	{
	}
}
