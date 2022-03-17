using UnityEngine;

public class BuildingConnectionLine : MonoBehaviour
{
	[SerializeField]
	private LineRenderer lr;

	[SerializeField]
	private AnimationCurve curvedPath;

	private Building _003CFromBuilding_003Ek__BackingField;

	private Building _003CToBuilding_003Ek__BackingField;

	public Building FromBuilding
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Building ToBuilding
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public void UpdateLine(Building from, Building to)
	{
	}

	private void SetLinearPos(Vector3 from, Vector3 to, float t)
	{
	}

	private void SetArchPos(Vector3 from, Vector3 to, float t)
	{
	}
}
