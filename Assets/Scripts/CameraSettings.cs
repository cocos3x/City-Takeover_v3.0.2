using DG.Tweening;
using System.Runtime.InteropServices;
using UnityEngine;

public struct CameraSettings
{
	public Vector3 pos;

	public Quaternion rot;

	public float fov;

	public CameraSettings(Camera cam)
	{
	}

	public void SetToSetting(Camera cam)
	{
	}

	public void AnimateToSetting(Camera cam, [Optional] TweenCallback callback)
	{
	}
}
