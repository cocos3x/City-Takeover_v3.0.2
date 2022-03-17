using System;

namespace Voodoo.Sauce.Internal
{
	public class NoAdsPurchaseDelegate : IPurchaseDelegate
	{
		private Action _OnPurchaseComplete;

		private Action _OnPurchaseFailure;

		public NoAdsPurchaseDelegate(Action onPurchaseComplete, Action onPurchaseFailure)
		{
		}

		public void OnInitializeSuccess()
		{
		}

		public void OnInitializeFailure(VoodooInitializationFailureReason reason)
		{
		}

		public void OnPurchaseComplete(string productId)
		{
		}

		public void OnPurchaseFailure(string productId, VoodooPurchaseFailureReason reason, string transactionId)
		{
		}
	}
}
