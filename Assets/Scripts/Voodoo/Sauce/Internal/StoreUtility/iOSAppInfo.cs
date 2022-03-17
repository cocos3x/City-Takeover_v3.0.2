using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Voodoo.Sauce.Internal.StoreUtility
{
	internal static class iOSAppInfo
	{
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public string currentVersion;

			internal void _003CGetStoreVersion_003Eb__0(int status, string version)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CGetStoreVersion_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

			private int _003CmaxIteration_003E5__2;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		private struct _003CGetAppUpdateStatus_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action<AppUpdateStatus> onAppUpdateStatusRetrieved;

			private TaskAwaiter<string> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static string storeVersion;

		private static AppUpdateStatus appUpdateStatus;

		public static Task<string> GetStoreVersion()
		{
			return null;
		}

		public static void GetAppUpdateStatus(Action<AppUpdateStatus> onAppUpdateStatusRetrieved)
		{
		}

		private static void OnStoreVersionRetrieved()
		{
		}

		public static void OpenStore()
		{
		}
	}
}
