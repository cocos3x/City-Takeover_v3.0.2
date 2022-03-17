using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugPopup : MonoBehaviour
	{
		[SerializeField]
		private Text _text;

		[SerializeField]
		private Button _button;

		public void Initialize(string text, [Optional] UnityAction buttonCallback)
		{
		}

		public void Initialize(UnityAction buttonCallback)
		{
		}

		public void Dispose()
		{
		}
	}
}
