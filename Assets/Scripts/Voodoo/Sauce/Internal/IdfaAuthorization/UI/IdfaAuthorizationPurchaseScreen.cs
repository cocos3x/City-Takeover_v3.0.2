using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.IdfaAuthorization.UI
{
	public class IdfaAuthorizationPurchaseScreen : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public Action OnConsent;

			public Action OnPurchase;

			internal void _003CInitialize_003Eb__0()
			{
			}

			internal void _003CInitialize_003Eb__1()
			{
			}
		}

		[SerializeField]
		private Text _titleText;

		[SerializeField]
		private Text _bodyText;

		[SerializeField]
		private Button _consentButton;

		[SerializeField]
		private Text _consentButtonText;

		[SerializeField]
		private Button _purchaseButton;

		[SerializeField]
		private Text _purchaseButtonText;

		[SerializeField]
		private GameObject _popupFrame;

		public void Initialize(Action OnConsent, Action OnPurchase)
		{
		}

		private static void RefreshHierarchySize(Transform transform)
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
