using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Voodoo.Sauce.Internal;

namespace Voodoo.Sauce.IAP
{
	internal static class IAPVerificationServices
	{
		[StructLayout(3)]
		private struct _003CSendToVerifyPurchase_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ProductReceivedInfo purchaseInfo;

			public VoodooSettings settings;

			public Action<bool> onComplete;

			private HttpResponseMessage _003Cresponse_003E5__2;

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

		private const string URL = "https://iap-validation-api.voodoo-gaming.io/purchase/verify";

		private const int Timeout = 3000;

		internal static void SendToVerifyPurchase(ProductReceivedInfo purchaseInfo, VoodooSettings settings, Action<bool> onComplete)
		{
		}
	}
}
