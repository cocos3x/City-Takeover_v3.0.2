using System;
using UnityEngine;

namespace com.adjust.sdk.purchase
{
	public class AdjustPurchase : MonoBehaviour
	{
		private const string errorMessage = "AdjustPurchase: SDK not started. Start it manually using the 'start' method.";

		private static IAdjustPurchase instance;

		private static Action<ADJPVerificationInfo> verificationInfoCallback;

		public bool startManually;

		public string appToken;

		public ADJPLogLevel logLevel;

		public ADJPEnvironment environment;

		private void Awake()
		{
		}

		public static void Init(ADJPConfig config)
		{
		}

		public static void VerifyPurchaseiOS(string receipt, string transactionId, string productId, Action<ADJPVerificationInfo> verificationInfoCallback, string sceneName = "AdjustPurchase")
		{
		}

		public static void VerifyPurchaseAndroid(string itemSku, string itemToken, string developerPayload, Action<ADJPVerificationInfo> verificationInfoCallback, string sceneName = "AdjustPurchase")
		{
		}

		public void GetNativeVerificationInfo(string stringVerificationInfo)
		{
		}
	}
}
