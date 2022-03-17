using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Voodoo.Sauce.Internal.CrossPromo.Canvas
{
	internal class DefaultFormat : AFormatManager
	{
		private sealed class _003CStartDisplay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DefaultFormat _003C_003E4__this;

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
			public _003CStartDisplay_003Ed__9(int _003C_003E1__state)
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

		private Text _gameName;

		private VideoManager _videoManager;

		[SerializeField]
		private GameObject _adLabel;

		[SerializeField]
		public RectTransform myCanvasTransformer;

		private static RectTransform _transformer;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public override void Display()
		{
		}

		private IEnumerator StartDisplay()
		{
			return null;
		}

		public static Vector3 RectTransformToScreenSpace()
		{
			return (Vector3)null;
		}

		public override void Hide()
		{
		}

		private void Enable(bool show)
		{
		}

		private void _003CStart_003Eb__7_0(VideoPlayer source)
		{
		}
	}
}
