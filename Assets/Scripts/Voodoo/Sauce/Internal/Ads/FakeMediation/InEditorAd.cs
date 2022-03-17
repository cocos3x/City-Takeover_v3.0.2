using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	internal class InEditorAd : MonoBehaviour
	{
		[SerializeField]
		protected GameObject rootView;

		[SerializeField]
		private Button _viewButton;

		[SerializeField]
		private Button _closeButton;

		public Action onClick;

		public Action onClose;

		private void Awake()
		{
		}

		public virtual void StartAd()
		{
		}

		public virtual void StopAd()
		{
		}

		private void _003CAwake_003Eb__5_0()
		{
		}

		private void _003CAwake_003Eb__5_1()
		{
		}
	}
}
