using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.GDPR.UI
{
	public class VoodooGDPRMessageDialog : MonoBehaviour
	{
		[SerializeField]
		private Text _title;

		[SerializeField]
		private Text _message;

		[SerializeField]
		private Text _close;

		private Action _closeCallback;

		public void Show(string title, string message, string close, Action closeCallback)
		{
		}

		public void Close()
		{
		}
	}
}
