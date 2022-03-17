using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TutorialHand : MonoBehaviour
{
	private sealed class _003CIGo_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialHand _003C_003E4__this;

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
		public _003CIGo_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CIRestart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialHand _003C_003E4__this;

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
		public _003CIRestart_003Ed__18(int _003C_003E1__state)
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
	private Vector3[] to;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private bool localPosition;

	[SerializeField]
	private SpriteRenderer sr;

	private int goingIndex;

	private Vector3 startingPos;

	private Vector3 target;

	private bool canMove;

	private Vector3 Position
	{
		get
		{
			return (Vector3)null;
		}
		set
		{
		}
	}

	public void SetSpeed(float speed, bool restart)
	{
	}

	public void SetHandTargetPosition(Vector3[] position, bool restart)
	{
	}

	public void SetStartingPosition(Vector3 position, bool restart)
	{
	}

	private void Start()
	{
	}

	public void Go()
	{
	}

	private IEnumerator IGo()
	{
		return null;
	}

	public void Restart()
	{
	}

	private IEnumerator IRestart()
	{
		return null;
	}

	private void Update()
	{
	}

	private Vector3 GetPositionByIndex(int i)
	{
		return (Vector3)null;
	}
}
