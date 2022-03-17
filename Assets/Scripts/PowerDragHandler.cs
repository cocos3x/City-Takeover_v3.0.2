using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PowerDragHandler : MonoBehaviour, IEndDragHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler
{
	[SerializeField]
	private LayerMask _BuildingLayerMask;

	private PowerUpData _Datas;

	private GameManager _GameManager;

	private Building _BuildingTarget;

	private bool CanDrag => false;

	private bool CanUse => false;

	public event Action OnUse
	{
		add
		{
		}
		remove
		{
		}
	}

	public void SetDatas(PowerUpData datas)
	{
	}

	private void ResetTarget()
	{
	}

	public void OnClick()
	{
	}

	private void HandleAdRefreshTimer()
	{
	}

	private void HandleOnClickActivation()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void Use()
	{
	}

	private void OnDisable()
	{
	}

	private void TrackPowerTimerReset(string powerId, bool _rvWatched, bool _fsWatched)
	{
	}

	private void TrackPowerUpUse(string _ID, int _Quantity)
	{
	}

	private void _003CHandleAdRefreshTimer_003Eb__14_0(bool success)
	{
	}
}
