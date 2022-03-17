using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.IAP
{
	public class NoAdsButton : MonoBehaviour, IPurchaseDelegate
	{
		private const string TAG = "NoAdsButton";

		private string _noAdsBundleId;

		private Button _button;

		private void Start()
		{
		}

		private void PurchaseNoAds()
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
