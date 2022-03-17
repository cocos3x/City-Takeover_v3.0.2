using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;

namespace Voodoo.Analytics
{
	internal class Tracker
	{
		private enum FileProcessStatus
		{
			Waiting,
			InProcess
		}

		private class FileProcessInfo
		{
			public FileProcessStatus Status;

			public DateTime? NextProcessDate;

			public int NumberOfTries;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<FileInfo, DateTime> _003C_003E9__15_0;

			public static Func<string, bool> _003C_003E9__15_1;

			internal DateTime _003CRetrieveAndSendEvents_003Eb__15_0(FileInfo p)
			{
				return (DateTime)null;
			}

			internal bool _003CRetrieveAndSendEvents_003Eb__15_1(string value)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass17_0
		{
			public FileSystemInfo file;

			public Tracker _003C_003E4__this;

			internal void _003CSendAndDeleteFiles_003Eb__0(bool succeeded)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public Event e;

			public Tracker _003C_003E4__this;

			internal void _003CTrackEvent_003Eb__0()
			{
			}
		}

		[StructLayout(3)]
		private struct _003CTrackEvent_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Event e;

			public Tracker _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private const string TAG = "Analytics - Tracker";

		private const string FilePrefix = "VoodooAnalytics-FileInProcess-";

		private static readonly string PersistenceFolder;

		private readonly int[] _backOffDelays;

		private readonly ConcurrentDictionary<string, FileProcessInfo> _queue;

		private static readonly object FileAccess;

		private string _lastFilePath;

		private int _eventNumberInFile;

		private IConfig _config;

		private static Tracker _instance;

		public static Tracker Instance => null;

		internal void Init(IConfig config, string proxyServer)
		{
		}

		private void OnTimedEvent()
		{
		}

		private void UpdateCurrentEventsFileName()
		{
		}

		private void RetrieveAndSendEvents()
		{
		}

		private bool SaveFileToSend(FileSystemInfo file)
		{
			return false;
		}

		private void SendAndDeleteFiles(List<string> events, FileSystemInfo file)
		{
		}

		internal Task TrackEvent(Event e)
		{
			return null;
		}

		private void _003CInit_003Eb__12_0(object sender, ElapsedEventArgs args)
		{
		}
	}
}
