using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Tools.AccessButton
{
	public class HidePanel : MonoBehaviour
	{
		public delegate void OnHideChangeState(bool appear);

		[StructLayout(3)]
		private struct _003CUIAppear_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public HidePanel _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public static OnHideChangeState HideChangeState;

		public CanvasGroup canvasGroup;

		public Image background;

		public RectTransform logo;

		private bool _visible;

		private const float LogoOnY = 0f;

		private const float LogoOffY = -256f;

		private const float LogoSpeedAppear = 20f;

		private const float BackgroundOn = 0.39f;

		private const float BackgroundOff = 0f;

		private const float BackgroundSpeedAppear = 0.02f;

		private static CancellationTokenSource _cancellationTokenSource;

		private void Start()
		{
		}

		private void ChangeState(bool appear)
		{
		}

		private void UIAppear()
		{
		}

		private void UIDisappear()
		{
		}

		private void OnDestroy()
		{
		}

		private void GroupVisibility(bool show)
		{
		}
	}
}
