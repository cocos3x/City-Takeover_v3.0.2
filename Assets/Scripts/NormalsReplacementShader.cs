using UnityEngine;

public class NormalsReplacementShader : MonoBehaviour
{
	[SerializeField]
	private Shader normalsShader;

	private RenderTexture renderTexture;

	private Camera camera;

	private void Start()
	{
	}
}
