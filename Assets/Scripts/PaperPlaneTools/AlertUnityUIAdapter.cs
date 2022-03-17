using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PaperPlaneTools
{
	public class AlertUnityUIAdapter : MonoBehaviour, IAlertPlatformAdapter
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<EventTrigger.Entry> _003C_003E9__9_0;

			internal bool _003CPaperPlaneTools_002EIAlertPlatformAdapter_002EShow_003Eb__9_0(EventTrigger.Entry foo)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public AlertUnityUIAdapter _003C_003E4__this;

			public AlertButton alertButton;

			internal void _003CSetButton_003Eb__0()
			{
			}

			internal void _003CSetButton_003Eb__1()
			{
			}
		}

		public Text titleText;

		public Text messageText;

		public Button positiveButton;

		public Button neutralButton;

		public Button negativeButton;

		public GameObject dismissPanel;

		private Action onDismiss;

		private void PaperPlaneTools_002EIAlertPlatformAdapter_002ESetOnDismiss(Action action)
		{
		}

		private void PaperPlaneTools_002EIAlertPlatformAdapter_002EDismiss()
		{
		}

		private void PaperPlaneTools_002EIAlertPlatformAdapter_002EShow(Alert alert)
		{
		}

		private void PaperPlaneTools_002EIAlertPlatformAdapter_002EHandleEvent(string name, string value)
		{
		}

		private void SetButton(Button uiButton, AlertButton alertButton)
		{
		}

		private void _003CPaperPlaneTools_002EIAlertPlatformAdapter_002EShow_003Eb__9_1(BaseEventData eventData)
		{
		}
	}
}
