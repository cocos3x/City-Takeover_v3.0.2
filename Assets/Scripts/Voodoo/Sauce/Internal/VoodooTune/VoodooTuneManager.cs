using SimpleJSON;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	public static class VoodooTuneManager
	{
		public enum SessionParameter
		{
			app_open_count,
			vs_version,
			advertising_id,
			sessions_count,
			games_count,
			best_score,
			level,
			win_rate
		}

		public delegate void GetConfigurationHierarchyCallback(VoodooTuneNode voodooTuneRoot);

		public delegate void JoinClusterCallback(bool succeed);

		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public Timer timer;

			internal void _003CInit_003Eb__0(object sender, ElapsedEventArgs e)
			{
			}

			internal void _003CInit_003Eb__1(string response, string error, long responseCode, double durationInMilliseconds)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public string appId;

			internal void _003CGetAppId_003Eb__0(HttpStatusCode code, string response)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CGetAppId_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass30_0
		{
			public GetConfigurationHierarchyCallback getConfigurationHierarchyCallback;

			internal void _003CGetConfigurationHierarchy_003Eb__0(HttpStatusCode code, string response)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CGetConfigurationHierarchy_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public GetConfigurationHierarchyCallback getConfigurationHierarchyCallback;

			private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

			private TaskAwaiter<string> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass31_0
		{
			public JoinClusterCallback joinClusterCallback;

			internal void _003CJoinCluster_003Eb__0(HttpStatusCode code, string response)
			{
			}

			internal void _003CJoinCluster_003Eb__1(HttpStatusCode code, string response)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CJoinCluster_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public JoinClusterCallback joinClusterCallback;

			public string clusterId;

			private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

			private TaskAwaiter<string> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private const string TAG = "VoodooTuneManager";

		private const int DefaultInitTimeoutInMillisecondsWithoutCache = 3000;

		private static readonly VoodooTuneClusterApi.ConfigVersion ConfigVersion;

		private static readonly VoodooTune VoodooTune;

		private static readonly object Lock;

		private static bool _localConfigLoaded;

		private static string _initError;

		private static bool _initFinished;

		private static bool _isTimeout;

		private static string _initFinishedMessage;

		private static Action<string> _onInitFinishedEvent;

		private static string _deviceId;

		private static string _appId;

		internal static VoodooTuneInitAnalyticsInfoLog lastVoodooTuneInitInfo;

		private static readonly Dictionary<string, string> SessionParameters;

		public static int Timeout => 0;

		public static event Action<string> OnInitFinishedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void AddSessionParameters(Dictionary<SessionParameter, string> sessionParameters)
		{
		}

		public static void AddSessionParameter(SessionParameter sessionParameter, string value)
		{
		}

		public static void Init()
		{
		}

		public static void UpdateLastInitInfoAsTimeout()
		{
		}

		private static void LoadLocalVoodooTune()
		{
		}

		private static void InvokeOnInitFinishedEvent()
		{
		}

		private static Task<string> GetAppId()
		{
			return null;
		}

		public static Task GetConfigurationHierarchy(GetConfigurationHierarchyCallback getConfigurationHierarchyCallback)
		{
			return null;
		}

		internal static Task JoinCluster(string clusterId, JoinClusterCallback joinClusterCallback)
		{
			return null;
		}

		private static void ParseJsonNode(JSONNode json, VoodooTuneNode parentNode)
		{
		}

		private static void CreateVoodooTuneNode(KeyValuePair<string, JSONNode> jsonNode, VoodooTuneNode parentNode, VoodooTuneNode.Type type)
		{
		}

		public static List<T> GetSubclassesItems<T>() where T : class, new()
		{
			return null;
		}

		public static List<T> GetItems<T>() where T : class, new()
		{
			return null;
		}

		public static List<T> GetItemsOrDefaults<T>() where T : class, new()
		{
			return null;
		}

		public static T GetItem<T>() where T : class, new()
		{
			return null;
		}

		public static T GetItemOrDefault<T>() where T : class, new()
		{
			return null;
		}

		public static string JsonConfigurations(string type)
		{
			return "";
		}

		public static Dictionary<string, string> JsonConfigurations()
		{
			return null;
		}

		public static bool HasCache()
		{
			return false;
		}

		public static string GetSegmentationUuid()
		{
			return "";
		}

		public static string GetAbTestUuid()
		{
			return "";
		}

		public static string GetAbTestCohortName()
		{
			return "";
		}

		public static string GetAbTestCohortUuid()
		{
			return "";
		}

		public static string GetAbTestVersionUuid()
		{
			return "";
		}

		public static string GetClusterId()
		{
			return "";
		}

		public static bool GetDebuggerAuthorization()
		{
			return false;
		}
	}
}
