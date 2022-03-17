using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BossAvatar : MonoBehaviour
{
	private sealed class _003CIJumpingLoop_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAvatar _003C_003E4__this;

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
		public _003CIJumpingLoop_003Ed__6(int _003C_003E1__state)
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
	private Avatar avatar;

	private LevelManager levelManager;

	private DailyChallengesManager dcManager;

	private Building building;

	private int jumpCount;

	private void Start()
	{
	}

	private IEnumerator IJumpingLoop()
	{
		return null;
	}

	private void JumpOnRandomBuilding()
	{
	}

	private void OnBuildingCaptured(Building b, BuildingTeam oldTeam, Building fromBuilding)
	{
	}

	private void OnBuildingResized(Building b)
	{
	}

	private void _003CJumpOnRandomBuilding_003Eb__7_0()
	{
	}
}
