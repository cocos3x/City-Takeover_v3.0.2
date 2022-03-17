using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MC_SwitchTexture : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public Texture[] textures;

	public Material targetMaterial;

	private RawImage image;

	private int index;

	private void Awake()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void NextTexture()
	{
	}

	public void PrevTexture()
	{
	}

	private void ReloadTexture()
	{
	}
}
