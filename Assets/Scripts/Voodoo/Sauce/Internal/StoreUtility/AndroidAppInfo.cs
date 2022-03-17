using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Voodoo.Sauce.Internal.StoreUtility
{
	internal static class AndroidAppInfo
	{
		[StructLayout(3)]
		private struct _003CGetStoreVersion_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

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
		private struct _003CGetAppUpdateStatus_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action<AppUpdateStatus> onAppUpdateStatusRetrieved;

			private TaskAwaiter<int> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static AppUpdateCallback appUpdateCallback;

		private static int storeVersion;

		private static AppUpdateStatus appUpdateStatus;

		public static Task<int> GetStoreVersion()
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

		private static int GetAndroidBundleVersionCode()
		{
			return 0;
		}

		private static PackageInfo GetPackageInfo()
		{
			return null;
		}

		private static void GetAppUpdateCallback()
		{
		}
	}
}
