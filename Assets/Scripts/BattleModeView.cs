using DG.Tweening;
using UnityEngine;

public class BattleModeView : BaseScreenUi
{
	[SerializeField]
	private GameObject _battleModeContainer;

	[SerializeField]
	private GameObject _battleModeButton;

	[SerializeField]
	private GameObject _campaignModeButton;

	[SerializeField]
	private RectTransform _onBoardingHand;

	[SerializeField]
	private GameObject _onBoardingBackground;

	private Sequence _onBoardingSequence;

	private void Awake()
	{
	}

	private void OnGameModeChanged(EGameMode _GameMode)
	{
	}

	public void OnBattleModePressed()
	{
	}

	public void OnCampaignModePressed()
	{
	}

	public void OnPlayPressed()
	{
	}

	public void OnPlayWithPowerPressed()
	{
	}

	private void ShowBattleMode(bool _Active)
	{
	}

	public void ShowUnlockedView()
	{
	}

	private void ShowOnBoarding()
	{
	}

	private void HideOnBoarding()
	{
	}
}
