using UnityEngine;
using UnityEngine.UI;

public class UIGradient : BaseMeshEffect
{
	public Color m_color1;

	public Color m_color2;

	public float m_angle;

	public bool m_ignoreRatio;

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}
