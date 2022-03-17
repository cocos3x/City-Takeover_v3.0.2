using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class BattleModeTutorialUi : TutorialUi
{
	[SerializeField]
	private TMP_InputField _inputField;

	public override void ShowTutorial(TutorialStep tut, [Optional] Action callback)
	{
	}

	public void OnNameChanged(string _Name)
	{
	}
}
