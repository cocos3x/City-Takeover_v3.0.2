using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.GDPR.UI
{
	public class VoodooGDPRDeleteRequestScreen : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<PrivacyRequest> _003C_003E9__7_0;

			public static Action<PrivacyRequest> _003C_003E9__7_1;

			internal void _003CSendRequest_003Eb__7_0(PrivacyRequest request)
			{
			}

			internal void _003CSendRequest_003Eb__7_1(PrivacyRequest request)
			{
			}
		}

		private const string TAG = "VoodooGDPRDeleteScreen";

		public const string UserRequestedToBeForgottenPrefKey = "UserRequestedToBeForgotten";

		[SerializeField]
		private InputField _idfaField;

		[SerializeField]
		private InputField _emailField;

		[SerializeField]
		private Button _sendBtn;

		private void Start()
		{
		}

		private void UpdateSendButtonAvailability()
		{
		}

		public void SendRequest()
		{
		}

		private void _003CStart_003Eb__5_0(string c)
		{
		}
	}
}
