using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PaperPlaneTools
{
	public class Alert
	{
		public enum ButtonType
		{
			Positive,
			Negative,
			Neutral
		}

		private string _003CTitle_003Ek__BackingField;

		private string _003CMessage_003Ek__BackingField;

		private AlertButton _003CPositiveButton_003Ek__BackingField;

		private AlertButton _003CNegativeButton_003Ek__BackingField;

		private AlertButton _003CNeutralButton_003Ek__BackingField;

		private List<object> _003COptions_003Ek__BackingField;

		private Action _003COnDismiss_003Ek__BackingField;

		private IAlertPlatformAdapter _003CAdapter_003Ek__BackingField;

		public string Title
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string Message
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public AlertButton PositiveButton
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public AlertButton NegativeButton
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public AlertButton NeutralButton
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public List<object> Options
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Action OnDismiss
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IAlertPlatformAdapter Adapter
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Alert([Optional] string title, [Optional] string message)
		{
		}

		public Alert SetTitle(string title)
		{
			return null;
		}

		public Alert SetMessage(string title)
		{
			return null;
		}

		public Alert SetPositiveButton(string title, [Optional] Action handler)
		{
			return null;
		}

		public Alert SetNegativeButton(string title, [Optional] Action handler)
		{
			return null;
		}

		public Alert SetNeutralButton(string title, [Optional] Action handler)
		{
			return null;
		}

		public Alert AddOptions(object opt)
		{
			return null;
		}

		public Alert SetOptions(List<object> options)
		{
			return null;
		}

		public Alert SetOnDismiss(Action handler)
		{
			return null;
		}

		public Alert SetAdapter(IAlertPlatformAdapter adaper)
		{
			return null;
		}

		public void Show()
		{
		}

		public void Dismiss()
		{
		}
	}
}
