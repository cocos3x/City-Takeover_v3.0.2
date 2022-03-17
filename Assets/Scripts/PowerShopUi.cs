using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PowerShopUi : BaseScreenUi
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__4_0;

		internal void _003CAwake_003Eb__4_0()
		{
		}
	}

	[SerializeField]
	private PowerButtonShop _PowerButtonShop;

	[SerializeField]
	private RectTransform _PuContainer;

	[SerializeField]
	private Button _ContinueButton;

	[SerializeField]
	private PowerBar _PowerBar;

	private void Awake()
	{
	}

	public override void OnOpen()
	{
	}

	private bool SetupContainer()
	{
		return false;
	}
}
