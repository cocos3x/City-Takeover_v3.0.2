using UnityEngine;
using UnityEngine.UI;

public class BuildingCapturedTrigger : MonoBehaviour
{
	[SerializeField]
	private Building buildingToBeCaptured;

	[SerializeField]
	private Button.ButtonClickedEvent captureEvent;

	[SerializeField]
	private int triggerCount;

	private void Start()
	{
	}

	private void OnBuildingCaptured(Building b, BuildingTeam oldTeam, Building fromBuilding)
	{
	}
}
