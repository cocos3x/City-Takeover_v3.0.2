using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Internal.GDPR.UI
{
	public class VoodooDebuggerInstructionPopup : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public VoodooDebuggerInstructionPopup _003C_003E4__this;

			public bool showUserId;

			internal void _003CShow_003Eb__0(string advertisingId, bool trackingEnabled, string error)
			{
			}
		}

		[SerializeField]
		private GameObject _idParent;

		[SerializeField]
		private Text _deviceId;

		[SerializeField]
		private Button _copyButton;

		[SerializeField]
		private DebugPopup _debugPopup;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(string instruction, bool showUserId, [Optional] UnityAction buttonCallback)
		{
		}

		private void DisplayInstructions(bool showUserId, [Optional] string deviceId)
		{
		}

		private static void RefreshHierarchySize(Transform transform)
		{
		}

		private void _003CStart_003Eb__4_0()
		{
		}

		private void _003COnEnable_003Eb__5_0()
		{
		}
	}
}
