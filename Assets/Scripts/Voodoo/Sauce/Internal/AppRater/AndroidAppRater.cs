using PaperPlaneTools;
using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.AppRater
{
	public class AndroidAppRater : MonoBehaviour, IAlertPlatformAdapter
	{
		private const string TAG = "AndroidAppRater";

		private Action _positiveCallback;

		private Action _neutralCallback;

		private Action _negativeCallback;

		private Action _dismissCallback;

		private const string unityActivityClass = "com.unity3d.player.UnityPlayer";

		private const string voodooAppRaterClass = "io.voodoo.voodooapprater.AppRater";

		private void Awake()
		{
		}

		public void SetOnDismiss(Action action)
		{
		}

		public void Show(Alert alert)
		{
		}

		public void Dismiss()
		{
		}

		public void HandleEvent(string eventName, string value)
		{
		}

		private static void ShowNativeAlertDialog()
		{
		}

		public void OnPositiveButtonClick(string ratingString)
		{
		}

		public void OnNeutralButtonClick()
		{
		}
	}
}
