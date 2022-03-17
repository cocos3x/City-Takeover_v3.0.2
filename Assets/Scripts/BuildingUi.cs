using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUi : MonoBehaviour
{
	[SerializeField]
	private TMP_Text counter;

	[SerializeField]
	private GameObject connectionsContainer;

	[SerializeField]
	private List<Image> connectionFills;

	[SerializeField]
	private GameObject tapFinger;

	private Color color;

	public Sprite RegularSprite;

	public Sprite AttackSprite;

	public Sprite DefenseSprite;

	public Sprite AttackDefenseSprite;

	public void SetCounterText(string text)
	{
	}

	public void ShowCounterText(bool show)
	{
	}

	public void SetColor(Color color)
	{
	}

	public void UpdateConnectionVisual(BuildingType type)
	{
	}

	public void UpdateConnections(int totalConnections, int connected)
	{
	}

	public void ShowTapFinger(bool show)
	{
	}

	public void ShowConnectionsContainer(bool show)
	{
	}
}
