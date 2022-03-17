using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegionProgressNodeUi : MonoBehaviour
{
	public float t;

	[SerializeField]
	private Image frame;

	[SerializeField]
	private Image fill;

	[SerializeField]
	private TMP_Text numberText;

	[SerializeField]
	private Color onFrameColor;

	[SerializeField]
	private Color onFillColor;

	[SerializeField]
	private Color offFrameColor;

	[SerializeField]
	private Color offFillColor;

	public void SetLocked(bool locked)
	{
	}

	public void SetNumber(int n)
	{
	}
}
