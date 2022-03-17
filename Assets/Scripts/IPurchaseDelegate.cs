public interface IPurchaseDelegate
{
	void OnInitializeSuccess();

	void OnInitializeFailure(VoodooInitializationFailureReason reason);

	void OnPurchaseComplete(string productId);

	void OnPurchaseFailure(string productId, VoodooPurchaseFailureReason reason, string transactionId);
}
