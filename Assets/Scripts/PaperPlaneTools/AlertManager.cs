using System;
using System.Collections.Generic;

namespace PaperPlaneTools
{
	public class AlertManager
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<IAlertPlatformAdapter> _003C_003E9__6_0;

			internal IAlertPlatformAdapter _003Cget_Instance_003Eb__6_0()
			{
				return null;
			}
		}

		private IAlertPlatformAdapter currentAdapter;

		private Alert currentAlert;

		private List<Alert> queue;

		private static AlertManager instance;

		private Func<IAlertPlatformAdapter> _003CAlertFactory_003Ek__BackingField;

		public static AlertManager Instance => null;

		public Func<IAlertPlatformAdapter> AlertFactory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private AlertManager()
		{
		}

		public void Show(Alert alert)
		{
		}

		public void Dismiss(Alert alert)
		{
		}

		public void HandleEvent(string eventName, string value)
		{
		}

		private IAlertPlatformAdapter CreateAdapter()
		{
			return null;
		}

		private void OnDismiss()
		{
		}

		private void ShowNext()
		{
		}
	}
}
