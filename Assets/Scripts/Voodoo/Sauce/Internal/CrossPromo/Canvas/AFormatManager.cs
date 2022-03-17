using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.Canvas
{
	internal abstract class AFormatManager : MonoBehaviour
	{
		private sealed class _003CWaitCrossPromoReady_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AFormatManager _003C_003E4__this;

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
			public _003CWaitCrossPromoReady_003Ed__9(int _003C_003E1__state)
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

		public static AFormatManager Instance;

		protected AssetModel Asset;

		protected bool IsActive;

		protected bool IsWaiting;

		private const string ITUNES_URL = "https://itunes.apple.com/fr/app/apple-store/id{0}";

		private const string PLAYSTORE_URL = "https://play.google.com/store/apps/details?id={0}";

		public abstract void Display();

		public virtual void OnClickEvent()
		{
		}

		public abstract void Hide();

		protected IEnumerator WaitCrossPromoReady()
		{
			return null;
		}
	}
}
