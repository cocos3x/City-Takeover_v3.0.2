using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapUi : BaseScreenUi, IDragHandler, IEventSystemHandler, IPointerClickHandler
{
	[SerializeField]
	private CanvasGroup _unlockPopup;

	[SerializeField]
	private TextMeshProUGUI _levelCompleteText;

	[SerializeField]
	private TextMeshProUGUI _notEnoughStarsText;

	[SerializeField]
	private Image _environmentIconImage;

	[SerializeField]
	private TextMeshProUGUI _starsCounterText;

	[SerializeField]
	private CustomButton _unlockWithStarsButton;

	[SerializeField]
	private CustomButton _replayLevelsButton;

	[SerializeField]
	private RVButton _unlockButtonRV;

	[SerializeField]
	private CustomButton _okButton;

	[SerializeField]
	private ParticleSystem _unlockEffect;

	[SerializeField]
	private Image _dragCatcherImage;

	private RaycastHit[] _hitInfo;

	public void Start()
	{
	}

	public void OnOKPressed()
	{
	}

	public void OnDrag(PointerEventData ped)
	{
	}

	public void OnPointerClick(PointerEventData ped)
	{
	}

	public void DisplayUnlockPopup()
	{
	}

	private void _OnUnlockRVComplete(bool complete)
	{
	}

	public void OnUnlockNextSection()
	{
	}

	public void OnReplayLevelsClicked()
	{
	}

	public void SetAllButtonsInteractible(bool isInteractible)
	{
	}

	public void SetOkButtonActive(bool isActive)
	{
	}

	private void _003COnUnlockNextSection_003Eb__18_0()
	{
	}

	private void _003COnReplayLevelsClicked_003Eb__19_0()
	{
	}
}
