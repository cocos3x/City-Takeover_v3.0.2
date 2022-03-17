using System;
using System.Collections.Generic;
using UnityEngine;

public static class LogsTracker
{
	public delegate void LogCallback(LogMessage logMessage);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Application.LogCallback _003C_003E9__6_0;

		internal void _003CInitialize_003Eb__6_0(string condition, string trace, LogType type)
		{
		}
	}

	private static FixedSizedQueue<LogMessage> _exceptionsQueue;

	private static bool _initialized;

	public static IReadOnlyCollection<LogMessage> ExceptionsList => null;

	public static int ExceptionsCount => 0;

	public static event LogCallback ExceptionMessageReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void Initialize()
	{
	}
}
