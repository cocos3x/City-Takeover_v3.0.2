using UnityEngine;

public static class RendererExtensions
{
	private static int CountCornersVisibleFrom(this RectTransform rectTransform, Camera camera)
	{
		return 0;
	}

	public static bool IsFullyVisibleFrom(this RectTransform rectTransform, Camera camera)
	{
		return false;
	}

	public static bool IsVisibleFrom(this RectTransform rectTransform, Camera camera)
	{
		return false;
	}
}
