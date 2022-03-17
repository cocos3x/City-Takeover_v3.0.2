using UnityEngine;

public class SlotLevelBuilding : MonoBehaviour
{
	[SerializeField]
	private Renderer[] lightColors;

	[SerializeField]
	private Renderer[] darkColors;

	[SerializeField]
	private GameObject[] objects;

	public void Init(Material lightMat, Material darkMaterial)
	{
	}
}
