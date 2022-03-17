using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Voodoo.Sauce.Tools.AccessButton
{
	public class BubbleButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		[StructLayout(3)]
		private struct _003CHideButtonUI_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BubbleButton _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CShowButtonUI_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BubbleButton _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CEndOfDragBehavior_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BubbleButton _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public bool forceUpsideDown;

		public CanvasGroup canvasGroup;

		public RectTransform parentRT;

		public RectTransform myRect;

		public RectTransform hideArea;

		private bool _isUsable;

		private const float MAXSize = 1.5f;

		private const float DistanceHide = -1200f;

		private bool _isDragged;

		private Vector3 _startMousePos;

		private Vector3 _startPos;

		private bool _isXRestrict;

		private bool _isYRestrict;

		private float _fakeX;

		private float _fakeY;

		private float _halfWidth;

		private float _halfHeight;

		private Vector3 _endLerpPosition;

		private Vector3 _startLerpPosition;

		private const float DurationLerp = 0.1f;

		private EventSystem _eventSystem;

		private static CancellationTokenSource _mouseDownCts;

		private const string TAG = "AccessButton";

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetUpLerp()
		{
		}

		private void HideButtonUI()
		{
		}

		private void ShowButtonUI()
		{
		}

		private void EndOfDragBehavior()
		{
		}

		private void Resize()
		{
		}

		private void KeepInsideScreen()
		{
		}

		private void GroupVisibility(bool show)
		{
		}

		private void OnClick()
		{
		}

		public void OnPointerDown(PointerEventData ped)
		{
		}

		public void OnPointerUp(PointerEventData ped)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
