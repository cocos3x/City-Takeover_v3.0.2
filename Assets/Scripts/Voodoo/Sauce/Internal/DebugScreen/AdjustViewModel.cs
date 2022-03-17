using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class AdjustViewModel
	{
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			public UnityWebRequest request;

			public AdjustViewModel _003C_003E4__this;

			public Action<AdjustModel> action;

			internal void _003CCreateAndStartRequest_003Eb__0(AsyncOperation operation)
			{
			}
		}

		private const string AdjustTokenKey = "AdjustAuthorizationToken";

		private const string HostUrl = "https://api.adjust.com/device_service/api/v1/";

		private const string DeviceUrl = "https://api.adjust.com/device_service/api/v1/inspect_device?";

		private const string ForgetDeviceUrl = "https://api.adjust.com/device_service/api/v1/forget_device";

		private const string FindTokenLink = "http://help.adjust.com/resources/developer-guides#how-to-find-your-adjust-api-token";

		private const string ForgetDeviceTokenApiKey = "app_token";

		private const string ForgetDeviceAdIdApiKey = "adid";

		private const int Timeout = 3;

		private string _adId;

		private string _adjustToken;

		public readonly string AppToken;

		public string AdjustToken
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		private AdjustViewModel()
		{
		}

		public AdjustViewModel(string iosAppToken, string androidAppToken)
		{
		}

		public static void ShowFindTokenLink()
		{
		}

		public void RequestDeviceData(Action<AdjustModel> action)
		{
		}

		public void RequestForgetDevice(Action<AdjustModel> action)
		{
		}

		private void CreateAndStartRequest(string url, Action<AdjustModel> action, [Optional] WWWForm form)
		{
		}
	}
}
