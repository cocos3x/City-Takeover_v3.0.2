using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugLogMessageListItem : MonoBehaviour
	{
		[SerializeField]
		private Text _headerText;

		[SerializeField]
		private Text _bodyText;

		[SerializeField]
		private Button _button;

		private DebugExceptionsScreen _parent;

		private LogMessage _logMessage;

		public void Initialize(LogMessage logMessage, DebugExceptionsScreen parent)
		{
		}

		private void onButtonClick()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
