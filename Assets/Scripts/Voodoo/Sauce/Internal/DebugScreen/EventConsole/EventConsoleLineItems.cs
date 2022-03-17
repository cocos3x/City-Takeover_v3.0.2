using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.DebugScreen.EventConsole
{
	public class EventConsoleLineItems : MonoBehaviour
	{
		[SerializeField]
		private Text _eventName;

		[SerializeField]
		private Text _eventTimestamp;

		[SerializeField]
		private Text _eventStatus;

		[SerializeField]
		private Button _infoButton;

		public void SetOnClickListener(UnityAction onClickAction)
		{
		}

		public void SetEventNameText(string text)
		{
		}

		public void SetEventTimestampText(string text)
		{
		}

		public void SetEventStatus(DebugAnalyticsStateEnum stateEnum)
		{
		}
	}
}
