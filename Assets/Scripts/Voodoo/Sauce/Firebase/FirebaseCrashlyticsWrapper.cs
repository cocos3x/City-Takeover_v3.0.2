using System;

namespace Voodoo.Sauce.Firebase
{
	internal static class FirebaseCrashlyticsWrapper
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<bool> _003C_003E9__4_0;

			internal void _003CInitialize_003Eb__4_0(bool success)
			{
			}
		}

		private const string TAG = "FirebaseCrashlytics";

		private static int _timeElapsed;

		private static bool _isInitialized;

		private static bool _isEnabled;

		internal static void Initialize()
		{
		}

		internal static void InitKeys()
		{
		}

		internal static void SetLevelKey(string levelNumber)
		{
		}

		internal static void SetCustomKey(string key, string value)
		{
		}

		internal static void Log(string message)
		{
		}

		internal static void LogException(Exception exception)
		{
		}
	}
}
