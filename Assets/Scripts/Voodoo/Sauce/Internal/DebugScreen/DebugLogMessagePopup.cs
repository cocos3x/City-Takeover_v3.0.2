using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugLogMessagePopup : MonoBehaviour
	{
		[SerializeField]
		private Text _headerText;

		[SerializeField]
		private Text _bodyText;

		[SerializeField]
		private Button _closeScreen;

		private void Awake()
		{
		}

		public void Show(LogMessage logMessage)
		{
		}

		private void Hide()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
