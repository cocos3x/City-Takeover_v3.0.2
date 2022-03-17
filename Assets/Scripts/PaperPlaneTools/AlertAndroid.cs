using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PaperPlaneTools
{
	public class AlertAndroid
	{
		public enum ButtonType
		{
			POSITIVE = -1,
			NEGATIVE = -2,
			NEUTRAL = -3
		}

		private Dictionary<int, AlertButton> buttons;

		public Action OnDismiss;

		private string _003CTitle_003Ek__BackingField;

		private string _003CMessage_003Ek__BackingField;

		private bool _003CCancelable_003Ek__BackingField;

		public string Title
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string Message
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool Cancelable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AlertAndroid([Optional] string title, [Optional] string message)
		{
		}

		public void SetPositiveButton(string title, Action handler)
		{
		}

		public void SetNegativeButton(string title, Action handler)
		{
		}

		public void SetNeutralButton(string title, Action handler)
		{
		}

		public void SetButton(ButtonType whichButton, string title, Action handler)
		{
		}

		public void Show(string gameObjectName)
		{
		}

		public void Dismiss()
		{
		}

		public void HandleButtonClick(int whichButton)
		{
		}

		public void HandleCancel()
		{
		}

		public void HandleDismiss()
		{
		}
	}
}
