using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerButton : MonoBehaviour
{
	private static List<PowerButton> PuButtons;

	[SerializeField]
	private Image _Icon;

	[SerializeField]
	private PowerDragHandler _DragHandler;

	[SerializeField]
	private GameObject _QuantityIcon;

	[SerializeField]
	private TextMeshProUGUI _QuantityText;

	[SerializeField]
	private GameObject _TimerIcon;

	[SerializeField]
	private GameObject _AdIcon;

	[SerializeField]
	private TextMeshProUGUI _TimerText;

	[SerializeField]
	private GameObject _LockBg;

	[SerializeField]
	private GameObject _LockIcon;

	[SerializeField]
	private TextMeshProUGUI _LockIconText;

	[SerializeField]
	private GameObject _Arrow;

	private PowerUpData _PuDatas;

	private float _TimeBeforeNextUpdate;

	public PowerUpData PuDatas => null;

	public PowerDragHandler DragHandler => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void ForceDataUpdate()
	{
	}

	private void UpdateDatas()
	{
	}

	public void Update()
	{
	}

	private string FormatTime(int time)
	{
		return "";
	}

	private void OnEnable()
	{
	}

	public void SetDatas(PowerUpData datas)
	{
	}

	public void EnableArrow(bool _Active)
	{
	}
}
