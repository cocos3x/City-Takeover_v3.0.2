using UnityEngine;
using UnityEngine.UI;

public class DebugTextPair : MonoBehaviour
{
	[SerializeField]
	private Text _key;

	[SerializeField]
	private Text _value;

	[SerializeField]
	private Button _copyButton;

	private void Start()
	{
	}

	private void OnCopyButtonClicked()
	{
	}

	public void Refresh(string key, string value, bool displayValue = true)
	{
	}

	public void SetStyle(Color color, FontStyle style)
	{
	}

	public void ShowCopyButton(bool value)
	{
	}
}
