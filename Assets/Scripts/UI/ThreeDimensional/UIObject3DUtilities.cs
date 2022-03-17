using System;
using System.Collections.Generic;
using UnityEngine;

namespace UI.ThreeDimensional
{
	public static class UIObject3DUtilities
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<UIObject3D, Vector3>, float> _003C_003E9__5_0;

			internal float _003CGetNextFreeTargetContainerPosition_003Eb__5_0(KeyValuePair<UIObject3D, Vector3> v)
			{
				return 0f;
			}
		}

		private static Dictionary<UIObject3D, Vector3> targetContainers;

		public static Vector3 NormalizeRotation(Vector3 rotation)
		{
			return (Vector3)null;
		}

		public static float NormalizeAngle(float value)
		{
			return 0f;
		}

		internal static void RegisterTargetContainerPosition(UIObject3D uiObject3D, Vector3 position)
		{
		}

		internal static Vector3 GetTargetContainerPosition(UIObject3D uiObject3d)
		{
			return (Vector3)null;
		}

		internal static Vector3 GetNextFreeTargetContainerPosition()
		{
			return (Vector3)null;
		}

		internal static void UnRegisterTargetContainer(UIObject3D uiObject3D)
		{
		}
	}
}
