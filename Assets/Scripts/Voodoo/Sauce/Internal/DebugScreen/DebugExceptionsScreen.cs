using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugExceptionsScreen : MonoBehaviour
	{
		[SerializeField]
		private Transform _exceptionListItemParent;

		[SerializeField]
		private GameObject _exceptionListItemPrefab;

		[SerializeField]
		private DebugLogMessagePopup _logMessagePopup;

		[SerializeField]
		private GameObject _logsDisabledWarning;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void InitExceptionsList()
		{
		}

		public void ShowLogMessagePopup(LogMessage logMessage)
		{
		}

		private void ClearExceptionsList()
		{
		}

		private void LogsTrackerOnExceptionMessageReceived(LogMessage exceptionMessage)
		{
		}
	}
}
