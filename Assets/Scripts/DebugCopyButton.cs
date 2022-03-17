using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugCopyButton : MonoBehaviour
{
	[SerializeField]
	private List<Text> _values;

	[SerializeField]
	private Button _copyButton;

	public event Action buttonClicked
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnButtonClick()
	{
	}
}
