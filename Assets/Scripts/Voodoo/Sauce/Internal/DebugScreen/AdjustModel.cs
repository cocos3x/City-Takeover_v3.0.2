using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class AdjustModel
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<string, object>, AdjustEventModel> _003C_003E9__11_0;

			internal AdjustEventModel _003C_002Ector_003Eb__11_0(KeyValuePair<string, object> receivedEvent)
			{
				return null;
			}
		}

		private readonly bool IsSignatureCorrect;

		public readonly string InstallDateTime;

		public readonly List<AdjustEventModel> LastEvents;

		public readonly string Message;

		public readonly bool IsError;

		public readonly string AdId;

		private const string AdjustEventsKey = "LastEventTimes";

		private const string AdjustTrackerNameKey = "TrackerName";

		private const string AdjustTrackerNameRejectionKeyword = "rejected";

		private const string InstallDateTimeKey = "InstallTime";

		private const string AdIdKey = "Adid";

		public AdjustModel(string resultString, bool isError, string message)
		{
		}

		public string Status()
		{
			return "";
		}

		public string StatusMessage()
		{
			return "";
		}
	}
}
