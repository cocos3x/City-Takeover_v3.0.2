using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.IdfaAuthorization.UI
{
	public class IdfaAuthorizationScreenParent : MonoBehaviour
	{
		[SerializeField]
		private IdfaAuthorizationScreen _authorizationScreen;

		[SerializeField]
		private IdfaAuthorizationScreenFlowD _authorizationScreenFlowD;

		[SerializeField]
		private IdfaAuthorizationPurchaseScreen _purchaseScreen;

		public void InitializeIdfaScreen(Action OnAllow, Action OnDeny)
		{
		}

		public void InitializeIdfaConsentOrPurchaseScreen(Action OnConsent, Action OnPurchase)
		{
		}

		public void HideFakePopup()
		{
		}

		public void HidePurchasePopup()
		{
		}

		public void ShowPurchasePopup()
		{
		}
	}
}
