using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.ThreeDimensional
{
	public class DragRotateUIObject3D : MonoBehaviour
	{
		public bool RotateX;

		public bool InvertX;

		public bool RotateY;

		public bool InvertY;

		public float Sensitivity;

		private UIObject3D UIObject3D;

		private int _xMultiplier => 0;

		private int _yMultiplier => 0;

		private void Awake()
		{
		}

		private void SetupEvents()
		{
		}

		private void OnDrag(PointerEventData e)
		{
		}

		private void _003CSetupEvents_003Eb__11_0(BaseEventData e)
		{
		}
	}
}
