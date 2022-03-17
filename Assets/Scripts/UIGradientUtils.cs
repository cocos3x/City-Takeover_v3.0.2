using UnityEngine;

public static class UIGradientUtils
{
	public struct Matrix2x3
	{
		public float m00;

		public float m01;

		public float m02;

		public float m10;

		public float m11;

		public float m12;

		public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
		{
		}

		public static Vector2 operator *(Matrix2x3 m, Vector2 v)
		{
			return (Vector2)null;
		}
	}

	private static Vector2[] ms_verticesPositions;

	public static Vector2[] VerticePositions => null;

	public static Matrix2x3 LocalPositionMatrix(Rect rect, Vector2 dir)
	{
		return (Matrix2x3)null;
	}

	public static Vector2 RotationDir(float angle)
	{
		return (Vector2)null;
	}

	public static Vector2 CompensateAspectRatio(Rect rect, Vector2 dir)
	{
		return (Vector2)null;
	}

	public static float InverseLerp(float a, float b, float v)
	{
		return 0f;
	}

	public static Color Bilerp(Color a1, Color a2, Color b1, Color b2, Vector2 t)
	{
		return (Color)null;
	}

	public static void Lerp(UIVertex a, UIVertex b, float t, ref UIVertex c)
	{
	}
}
