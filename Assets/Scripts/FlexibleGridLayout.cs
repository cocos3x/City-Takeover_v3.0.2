using UnityEngine;
using UnityEngine.UI;

public class FlexibleGridLayout : LayoutGroup
{
	public enum FitType
	{
		Uniform,
		Width,
		Height,
		FixedRows,
		FixedColumns
	}

	public FitType fitType;

	public int rows;

	public int columns;

	public Vector2 cellSize;

	public Vector2 spacing;

	public bool fitX;

	public bool fitY;

	public override void CalculateLayoutInputVertical()
	{
	}

	public override void SetLayoutHorizontal()
	{
	}

	public override void SetLayoutVertical()
	{
	}
}
