using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugScreenUi : BaseScreenUi
{
	[SerializeField]
	private TMP_Text premiumText;

	[SerializeField]
	private TMP_Text greenScreenText;

	[SerializeField]
	private TMP_Text levelOverrideText;

	[SerializeField]
	private Slider levelOverrideSlider;

	[SerializeField]
	private TMP_Text avatarScaleText;

	[SerializeField]
	private Slider avatarScaleSlider;

	[SerializeField]
	private TMP_Text starsOverrideText;

	[SerializeField]
	private Slider starsOverrideSlider;

	private GameManager manager;

	public override void OnOpen()
	{
	}

	public void _OnBackPressed()
	{
	}

	public void _DeletePrefs()
	{
	}

	public void _GiveCoinsDebug()
	{
	}

	public void _GiveCrownsDebug()
	{
	}

	public void _DebugTogglePremium()
	{
	}

	public void _DebugUnlockAllSkins()
	{
	}

	public void _DebugToggleGreenScreen()
	{
	}

	public void _OnLevelSlideValueChanged()
	{
	}

	public void _OnAvatarScaleValueChanged()
	{
	}

	public void _OnDailyRewardYesterday()
	{
	}

	public void _OnStarsSlideValueChanged()
	{
	}
}
