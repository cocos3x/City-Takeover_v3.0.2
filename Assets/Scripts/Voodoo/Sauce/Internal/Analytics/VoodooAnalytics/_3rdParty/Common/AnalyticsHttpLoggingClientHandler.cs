using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Voodoo.Sauce.Internal.Analytics.VoodooAnalytics._3rdParty.Common
{
	public class AnalyticsHttpLoggingClientHandler : DelegatingHandler
	{
		[StructLayout(3)]
		private struct _003CSendAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

			public HttpRequestMessage request;

			public AnalyticsHttpLoggingClientHandler _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<string> _003C_003Eu__1;

			private HttpResponseMessage _003Cresponse_003E5__2;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private const string TAG = "Analytics - HttpLogger - ";

		public AnalyticsHttpLoggingClientHandler(HttpMessageHandler innerHandler)
		{
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return null;
		}

		[DebuggerHidden]
		private Task<HttpResponseMessage> _003C_003En__0(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
