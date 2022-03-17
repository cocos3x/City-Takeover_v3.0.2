using System.Collections.Generic;
using UnityEngine;

public class DebugCameraMovement : MonoBehaviour
{
	public class StateBase
	{
		protected float SENSITIVITY;

		protected Transform transform;

		public virtual void Start()
		{
		}

		public virtual void Update()
		{
		}

		public virtual void End()
		{
		}

		public StateBase(Transform transform)
		{
		}
	}

	public class SingleTouchState : StateBase
	{
		private Vector3 lastCoordinate;

		private Vector3 currentCoordinate;

		public SingleTouchState(Transform transform)
		{
		}

		public override void Start()
		{
		}

		public override void Update()
		{
		}
	}

	public class DoubleTouchState : StateBase
	{
		private float lastDistance;

		private float currentDistance;

		private Vector3 lastMid;

		private Vector3 currentMid;

		public DoubleTouchState(Transform transform)
		{
		}

		public override void Start()
		{
		}

		public override void Update()
		{
		}

		public float GetDistanceBetweenFingers()
		{
			return 0f;
		}

		public Vector3 GetMidPoint()
		{
			return (Vector3)null;
		}
	}

	private enum MoveState
	{
		NONE,
		SINGLE,
		DOUBLE
	}

	private Dictionary<MoveState, StateBase> states;

	private MoveState currentState;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
