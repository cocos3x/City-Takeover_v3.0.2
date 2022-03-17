using Firebase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voodoo.Sauce.Internal.Firebase
{
	public static class FirebaseInitialization
	{
		private enum InitState
		{
			NONE,
			SUCCESS,
			FAIL
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<Task<DependencyStatus>> _003C_003E9__4_0;

			internal void _003CInitialize_003Eb__4_0(Task<DependencyStatus> task)
			{
			}
		}

		private const string TAG = "FirebaseInitialization";

		private static InitState _initState;

		private static readonly List<Action<bool>> _Callbacks;

		public static void Initialize()
		{
		}

		public static void Subscribe(Action<bool> callback)
		{
		}

		private static void OnInitComplete()
		{
		}
	}
}
