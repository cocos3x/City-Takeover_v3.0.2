using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.IdfaAuthorization.UI
{
	public class IdfaAuthorizationScreen : MonoBehaviour
	{
		[SerializeField]
		private Text _titleText;

		[SerializeField]
		private Text _bodyText;

		[SerializeField]
		private Text _denyButtonText;

		[SerializeField]
		private Text _allowButtonText;

		[SerializeField]
		private GameObject _popupFrame;

		[SerializeField]
		private IdfaAuthorizationBackground _authorizationBackground;

		public void Initialize(Action OnAllow, Action OnDeny)
		{
		}

		private static void RefreshHierarchySize(Transform transform)
		{
		}

		public void HideFakePopup()
		{
		}
	}
}
