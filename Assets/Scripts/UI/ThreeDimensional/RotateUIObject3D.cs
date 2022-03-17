using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.ThreeDimensional
{
	public class RotateUIObject3D : MonoBehaviour
	{
		public enum eRotationMode
		{
			Constant,
			WhenMouseIsOver,
			WhenMouseIsOverThenSnapBack
		}

		private sealed class _003CSnapBack_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RotateUIObject3D _003C_003E4__this;

			public float time;

			private float _003CtimeStarted_003E5__2;

			private float _003CpercentageComplete_003E5__3;

			private Vector3 _003CsnapStartRotation_003E5__4;

			private float _003CdesiredX_003E5__5;

			private float _003CdesiredY_003E5__6;

			private float _003CdesiredZ_003E5__7;

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
			public _003CSnapBack_003Ed__22(int _003C_003E1__state)
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

		public eRotationMode RotationMode;

		public bool RotateX;

		public float RotateXSpeed;

		public bool RotateY;

		public float RotateYSpeed;

		public bool RotateZ;

		public float RotateZSpeed;

		public float snapbackTime;

		private UIObject3D UIObject3D;

		private bool mouseIsOver;

		private Vector3 initialRotation;

		private EventTrigger _eventTrigger;

		private float timeSinceLastUpdate;

		private bool _isQuitting;

		private EventTrigger eventTrigger => null;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateRotation()
		{
		}

		private void SetupEvents()
		{
		}

		private void OnPointerEnter()
		{
		}

		private void OnPointerExit()
		{
		}

		private IEnumerator SnapBack(float time)
		{
			return null;
		}

		public virtual void OnApplicationQuit()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private void _003CSetupEvents_003Eb__19_0(BaseEventData e)
		{
		}

		private void _003CSetupEvents_003Eb__19_1(BaseEventData e)
		{
		}
	}
}
