using System;
using TMPro;
using UnityEngine;

public class GameOverUi : BaseScreenUi
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<bool> _003C_003E9__10_1;

		internal void _003C_Skip_003Eg__Skip_007C10_0()
		{
		}

		internal void _003C_Skip_003Eb__10_1(bool success)
		{
		}
	}

	[SerializeField]
	private TMP_Text levelText;

	[SerializeField]
	private GameObject skipButton;

	[SerializeField]
	private GameObject winStreakKeepBonusButton;

	[SerializeField]
	private TMP_Text winStreakGoldBonus;

	[SerializeField]
	private TMP_Text winStreakFloorBonus;

	private bool _saveWinStreak;

	public virtual void Init(int level)
	{
	}

	public void _OnContinueButtonClicked()
	{
	}

	private void _Continue()
	{
	}

	public void _OnContinueKeepWinStreakButtonClicked()
	{
	}

	public void _Skip()
	{
	}

	private void _003C_OnContinueButtonClicked_003Eb__7_0()
	{
	}

	private void _003C_OnContinueKeepWinStreakButtonClicked_003Eg__Continue_007C9_0()
	{
	}

	private void _003C_OnContinueKeepWinStreakButtonClicked_003Eb__9_1(bool success)
	{
	}
}
