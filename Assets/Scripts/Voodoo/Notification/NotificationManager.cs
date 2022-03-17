using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using VoodooPackages.Tech;

namespace Voodoo.Notification
{
	public class NotificationManager : SingletonMB<NotificationManager>
	{
		private sealed class _003CinitWithAuthorizationRequest_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NotificationManager _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CinitWithAuthorizationRequest_003Ed__3(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private INotificationSender _notificationSender;

		private List<PowerUpData> _powers;

		private void Start()
		{
		}

		private IEnumerator initWithAuthorizationRequest()
		{
			return null;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public bool AppWasOpenedViaNotificationClick()
		{
			return false;
		}

		private void SendPowerUpNotification(TimeSpan sendIn)
		{
		}

		public void RegisterPowerUp(PowerUpData puData)
		{
		}

		public void RefreshNotification()
		{
		}

		private void TrackNotificationClick()
		{
		}
	}
}
