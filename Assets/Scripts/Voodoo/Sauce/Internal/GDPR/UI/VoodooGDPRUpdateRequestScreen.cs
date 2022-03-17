using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.GDPR.UI
{
	public class VoodooGDPRUpdateRequestScreen : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<PrivacyRequest> _003C_003E9__9_0;

			public static Action<PrivacyRequest> _003C_003E9__9_1;

			internal void _003CSendRequest_003Eb__9_0(PrivacyRequest request)
			{
			}

			internal void _003CSendRequest_003Eb__9_1(PrivacyRequest request)
			{
			}
		}

		private const string TAG = "VoodooGDPRUpdateScreen";

		[SerializeField]
		private InputField _idfaField;

		[SerializeField]
		private Dropdown _countryCodeField;

		[SerializeField]
		private InputField _phoneField;

		[SerializeField]
		private InputField _emailField;

		[SerializeField]
		private Button _sendBtn;

		[SerializeField]
		private Button _debuggerButton;

		private void Start()
		{
		}

		private void UpdateSendButtonAvailability()
		{
		}

		public void SendRequest()
		{
		}

		private void _003CStart_003Eb__7_0(string c)
		{
		}

		private void _003CStart_003Eb__7_1(string c)
		{
		}
	}
}
