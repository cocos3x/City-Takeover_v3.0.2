using UnityEngine;

public class NodeEnvironment : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer[] m_IslandPart;

	[SerializeField]
	private Transform[] m_PropsPosition;

	public MeshRenderer[] IslandPart => null;

	public Transform[] PropsPosition => null;

	public void ClearProps()
	{
	}
}
