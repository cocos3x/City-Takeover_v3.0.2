using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Networking;

namespace Voodoo.Sauce.Internal.GDPR
{
	public class Requests : MonoBehaviour
	{
		private sealed class _003CdoRequest_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string jsonData;

			public string url;

			public Dictionary<string, string> data;

			public Dictionary<string, string> headers;

			public Action<UnityWebRequest> onSuccess;

			public Action<UnityWebRequest> onError;

			private UnityWebRequest _003Crequest_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CdoRequest_003Ed__5(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private static Requests _instance;

		private void Awake()
		{
		}

		public static void Get(string url, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
		}

		public static void Post(string url, Dictionary<string, string> data, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
		}

		public static void PostJson(string url, string jsonData, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
		}

		private static IEnumerator doRequest(string url, string jsonData, Dictionary<string, string> data, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
			return null;
		}
	}
}
