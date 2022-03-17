using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.IdfaAuthorization.UI
{
	public class IdfaAuthorizationScreenFlowD : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Action OnAllow;

			internal void _003CInitialize_003Eb__0()
			{
			}
		}

		[SerializeField]
		private Text _titleText;

		[SerializeField]
		private Text _bodyText;

		[SerializeField]
		private Button _allowButton;

		[SerializeField]
		private Text _allowButtonText;

		[SerializeField]
		private GameObject _popupFrame;

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
