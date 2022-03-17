using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HazardInfoUI : MonoBehaviour
{
	private enum VisibilityState
	{
		SHOWING,
		VISIBLE,
		HIDING,
		HIDDEN
	}

	public RectTransform Content;

	public RectTransform ProtectionButton;

	public TMP_Text HazardText;

	public Image HazardTypeImage;

	public string IceTornadoText;

	public Sprite IceTornadoSprite;

	public Material IceTornadoMaterial;

	public Color IceTornadoFontColor;

	public string MeteorText;

	public Sprite MeteorSprite;

	public Material MeteorMaterial;

	public Color MeteorFontColor;

	public string ThunderText;

	public Sprite ThunderSprite;

	public Material ThunderMaterial;

	public Color ThunderFontColor;

	private HazardManager HazardManager;

	private VisibilityState _visibilityState;

	public void Init()
	{
	}

	private void Update()
	{
	}

	public void Show(HazardManager.HazardType type)
	{
	}

	public void Hide()
	{
	}

	public void OnProtectionClicked()
	{
	}

	private void _003CShow_003Eb__21_0()
	{
	}

	private void _003CHide_003Eb__22_0()
	{
	}

	private void _003COnProtectionClicked_003Eb__23_0()
	{
	}

	private void _003COnProtectionClicked_003Eb__23_1(bool success)
	{
	}
}
