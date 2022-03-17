using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.IdfaAuthorization.UI
{
	public class IdfaAuthorizationBackground : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public Action OnDeny;

			public Action OnAllow;

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
		private Button _denyButton;

		[SerializeField]
		private Text _denyButtonText;

		[SerializeField]
		private Button _allowButton;

		[SerializeField]
		private Text _allowButtonText;

		public void Initialize(Action OnAllow, Action OnDeny)
		{
		}

		private static void RefreshHierarchySize(Transform transform)
		{
		}
	}
}
