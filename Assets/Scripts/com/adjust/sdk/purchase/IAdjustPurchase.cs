using System;

namespace com.adjust.sdk.purchase
{
	public interface IAdjustPurchase
	{
		void Init(ADJPConfig config);

		void VerifyPurchaseiOS(string receipt, string transactionId, string productId, string sceneName = "AdjustPurchase");

		void VerifyPurchaseAndroid(string itemSku, string itemToken, string developerPayload, Action<ADJPVerificationInfo> verificationInfoCallback);
	}
}
