using System;

namespace PaperPlaneTools
{
	public class AlertIOSButton
	{
		public enum Type
		{
			Default,
			Cancel,
			Destructive
		}

		private Type _003CWhichButton_003Ek__BackingField;

		private string _003CTitle_003Ek__BackingField;

		private Action _003CHandler_003Ek__BackingField;

		private bool _003CIsPreferable_003Ek__BackingField;

		public Type WhichButton
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (Type)null;
			}
			private set
			{
			}
		}

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

		public Action Handler
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool IsPreferable
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public AlertIOSButton(Type whichButton, string title, Action handler, bool isPreferable)
		{
		}
	}
}
