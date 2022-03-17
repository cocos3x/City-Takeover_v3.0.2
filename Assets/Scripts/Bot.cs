using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bot : MonoBehaviour
{
	public enum ActionType
	{
		CONNECT,
		DISCONNECT,
		WAIT
	}

	[Serializable]
	public class Action
	{
		public ActionType actionType;

		public float waitTime;

		public Building fromBuilding;

		public Building toBuilding;
	}

	private sealed class _003CActionsLoop_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Bot _003C_003E4__this;

		private int _003Ci_003E5__2;

		private Action _003Ca_003E5__3;

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
		public _003CActionsLoop_003Ed__12(int _003C_003E1__state)
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

	public BuildingTeam team;

	public bool AllowBrainTakeoverAfterActions;

	public Vector2 decisionMakingTimeRange;

	public List<Action> actions;

	private BotAction _botAction;

	private Coroutine _currentCoroutine;

	private void Start()
	{
	}

	public void SetData(SerializableEditorBot _BotData)
	{
	}

	public void Init()
	{
	}

	public void InitActionConfig(BotActionConfig _Config, bool _DeepBot)
	{
	}

	private IEnumerator ActionsLoop()
	{
		return null;
	}

	public void Stop()
	{
	}

	private void DebugLog(string s)
	{
	}
}
