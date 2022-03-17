using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Voodoo.Sauce.Internal.EnvironmentSettings;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	internal static class VoodooTuneClusterApi
	{
		public enum ConfigVersion
		{
			live,
			wip
		}

		public enum Platform
		{
			Android,
			iOS
		}

		public enum RequestType
		{
			Get,
			Put,
			Delete
		}

		public delegate void RequestCallback(HttpStatusCode statusCode, string response);

		[StructLayout(3)]
		private struct _003CGetAppId_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Platform platform;

			public string bundleId;

			public RequestCallback callback;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CGetConfiguration_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string appId;

			public ConfigVersion configVersion;

			public RequestCallback callback;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CPutCluster_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string appId;

			public string deviceId;

			public string clusterId;

			public ConfigVersion configVersion;

			public RequestCallback callback;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CDeleteCluster_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string appId;

			public string deviceId;

			public RequestCallback callback;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CGetCluster_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string appId;

			public string deviceId;

			public RequestCallback callback;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CRequest_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RequestType requestType;

			public string url;

			public HttpContent httpContent;

			public RequestCallback callback;

			private HttpClient _003Cclient_003E5__2;

			private HttpResponseMessage _003Cresponse_003E5__3;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static readonly string ServerUrl;

		private const string AppIdPath = "/api/app/{0}";

		private const string ConfigsPath = "/api/app/{0}/version/configuration/{1}";

		private const string ClusterPath = "/api/app/{0}/user/{1}";

		private const string PutClusterContent = "{{ \"clusterId\": \"{0}\", \"version\": \"{1}\" }}";

		private const string IOSstoreParameter = "force_ios";

		private static readonly Dictionary<Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Server, string> _tokenDictionary;

		private static readonly string Token;

		private const int Timeout = 3000;

		internal static Task GetAppId(string bundleId, Platform platform, RequestCallback callback)
		{
			return null;
		}

		internal static Task GetConfiguration(string appId, ConfigVersion configVersion, RequestCallback callback)
		{
			return null;
		}

		internal static Task PutCluster(string appId, string deviceId, string clusterId, ConfigVersion configVersion, RequestCallback callback)
		{
			return null;
		}

		internal static Task DeleteCluster(string appId, string deviceId, RequestCallback callback)
		{
			return null;
		}

		internal static Task GetCluster(string appId, string deviceId, RequestCallback callback)
		{
			return null;
		}

		internal static Task Request(string url, RequestType requestType, RequestCallback callback, [Optional] HttpContent httpContent)
		{
			return null;
		}
	}
}
