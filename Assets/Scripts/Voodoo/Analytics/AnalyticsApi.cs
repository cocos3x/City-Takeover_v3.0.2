using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Voodoo.Analytics
{
	internal static class AnalyticsApi
	{
		[StructLayout(3)]
		private struct _003CSendEvents_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public List<string> events;

			public Action<bool> complete;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private const string TAG = "Analytics - Sender";

		private static HttpClient _client;

		private static string _003CAnalyticsGatewayUrl_003Ek__BackingField;

		private static string _003CProxyServer_003Ek__BackingField;

		private static string AnalyticsGatewayUrl
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public static string ProxyServer
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		private static HttpClient DefaultVoodooAnalyticsHttpClient()
		{
			return null;
		}

		internal static void SetAnalyticsGatewayUrl(string url)
		{
		}

		internal static void SetHttpClient(HttpClient httpClient)
		{
		}

		internal static void SendEvents(List<string> events, Action<bool> complete)
		{
		}
	}
}
