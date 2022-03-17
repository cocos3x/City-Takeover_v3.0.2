using System;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.Networking;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	internal static class VoodooTuneApi
	{
		private delegate void OnUrlCallback(string url);

		internal delegate void OnConfigLoaded(string response, string error, long responseCode, double durationInMilliseconds);

		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public OnConfigLoaded callback;

			internal void _003CLoad_003Eb__0(string url)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass4_1
		{
			public double durationInMilliseconds;

			public Timer timer;

			public UnityWebRequest request;

			public _003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals1;

			internal void _003CLoad_003Eb__1(object sender, ElapsedEventArgs e)
			{
			}

			internal void _003CLoad_003Eb__2(AsyncOperation operation)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public string idfa;

			public Dictionary<string, string> parameters;

			public OnUrlCallback callback;

			internal void _003CVoodooTuneApiUrl_003Eb__0(string advertisingId, bool trackingEnabled, string error)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<string, string>, string> _003C_003E9__5_1;

			internal string _003CVoodooTuneApiUrl_003Eb__5_1(KeyValuePair<string, string> x)
			{
				return "";
			}
		}

		private const string TAG = "VoodooTuneApi";

		private static readonly string VoodooTuneApiBaseUrl;

		internal static void Load(Dictionary<string, string> parameters, OnConfigLoaded callback)
		{
		}

		private static void VoodooTuneApiUrl(Dictionary<string, string> parameters, OnUrlCallback callback)
		{
		}
	}
}
