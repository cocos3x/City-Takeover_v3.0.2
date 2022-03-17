using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUi : BaseScreenUi
{
	[SerializeField]
	private TMP_Text titleText;

	[SerializeField]
	private TMP_Text descriptionText;

	[SerializeField]
	private TMP_Text onlyText;

	[SerializeField]
	private Image image;

	private Action returnCallback;

	private float _previousSpeed;

	public virtual void ShowTutorial(TutorialStep tut, [Optional] Action callback)
	{
	}

	public void ShowTextOnly(string text, [Optional] Action callback)
	{
	}

	private void Init(string title, string description, Sprite img, [Optional] Action callback)
	{
	}

	public void OnOkButtonClicked()
	{
	}
}
