using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Voodoo.Analytics
{
	public static class VoodooAnalyticsManager
	{
		private struct QueuedEvent
		{
			public string EventName;

			public string EventDataJson;

			public string EventType;

			public string EventCustomVariablesJson;

			public string EventId;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			[StructLayout(3)]
			private struct _003C_003CInternalTrackEvent_003Eb__12_0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncVoidMethodBuilder _003C_003Et__builder;

				public Event e;

				private TaskAwaiter _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public static readonly _003C_003Ec _003C_003E9;

			public static Action<QueuedEvent> _003C_003E9__7_0;

			public static Action<Event> _003C_003E9__12_0;

			internal void _003CSendQueuedEvents_003Eb__7_0(QueuedEvent queuedEvent)
			{
			}

			internal void _003CInternalTrackEvent_003Eb__12_0(Event e)
			{
			}
		}

		private const string TAG = "VoodooAnalyticsManager";

		private static bool _isInitialized;

		private static readonly List<QueuedEvent> QueuedEvents;

		private static readonly Dictionary<AnalyticParameters, object> AnalyticsParameters;

		public static void AddSessionParameters(Dictionary<AnalyticParameters, object> sessionParameters)
		{
		}

		public static void AddSessionParameter(AnalyticParameters sessionParameter, object value)
		{
		}

		public static void Init(IConfig config, string proxyServer)
		{
		}

		private static void SendQueuedEvents()
		{
		}

		public static void TrackEvent(EventName eventName, Dictionary<string, object> data, [Optional] string eventType, [Optional] Dictionary<string, object> customVariables, [Optional] string eventId)
		{
		}

		public static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, [Optional] string eventType, [Optional] string eventId)
		{
		}

		private static void TrackEvent(string eventName, Dictionary<string, object> data, [Optional] string eventType, [Optional] Dictionary<string, object> customVariables, [Optional] string eventId)
		{
		}

		public static void TrackEvent(EventName eventName, [Optional] string data, [Optional] string eventType, [Optional] Dictionary<string, object> customVariables, [Optional] string eventId)
		{
		}

		private static void InternalTrackEvent(string eventName, string dataJson, string eventType, string customVariablesJson, string eventId)
		{
		}
	}
}
