using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustEventSuccess
	{
		private string _003CAdid_003Ek__BackingField;

		private string _003CMessage_003Ek__BackingField;

		private string _003CTimestamp_003Ek__BackingField;

		private string _003CEventToken_003Ek__BackingField;

		private string _003CCallbackId_003Ek__BackingField;

		private Dictionary<string, object> _003CJsonResponse_003Ek__BackingField;

		public string Adid
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string Message
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string Timestamp
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string EventToken
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string CallbackId
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public Dictionary<string, object> JsonResponse
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdjustEventSuccess()
		{
		}

		public AdjustEventSuccess(Dictionary<string, string> eventSuccessDataMap)
		{
		}

		public AdjustEventSuccess(string jsonString)
		{
		}

		public void BuildJsonResponseFromString(string jsonResponseString)
		{
		}

		public string GetJsonResponse()
		{
			return "";
		}
	}
}
