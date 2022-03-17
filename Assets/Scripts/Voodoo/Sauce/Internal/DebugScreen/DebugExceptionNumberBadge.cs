using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugExceptionNumberBadge : MonoBehaviour
	{
		[SerializeField]
		private Text _numberText;

		[SerializeField]
		private bool _hideIfEmpty;

		[SerializeField]
		private GameObject _badgeObject;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LogsTrackerOnExceptionMessageReceived(LogMessage exceptionMessage)
		{
		}
	}
}
