using System;
using UnityEngine;

namespace com.adjust.sdk.purchase
{
	public class AdjustPurchaseAndroid : IAdjustPurchase
	{
		private class VerificationInfoListener : AndroidJavaProxy
		{
			private Action<ADJPVerificationInfo> callback;

			public VerificationInfoListener(Action<ADJPVerificationInfo> pCallback)
			{
			}

			public void onVerificationFinished(AndroidJavaObject verificationInfo)
			{
			}
		}

		private const string sdkPrefix = "unity1.0.1";

		private AndroidJavaClass ajcAdjustPurchase;

		private VerificationInfoListener verificationInfoListener;

		private Action<ADJPVerificationInfo> verificationInfoCallback;

		public void Init(ADJPConfig config)
		{
		}

		public void VerifyPurchaseiOS(string receipt, string transactionId, string productId, string sceneName)
		{
		}

		public void VerifyPurchaseAndroid(string itemSku, string itemToken, string developerPayload, Action<ADJPVerificationInfo> verificationInfoCallback)
		{
		}
	}
}
