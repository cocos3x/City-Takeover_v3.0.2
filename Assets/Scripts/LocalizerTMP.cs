using TMPro;
using UnityEngine;

public class LocalizerTMP : MonoBehaviour, ISerializationCallbackReceiver
{
	[SerializeField]
	private TMP_Text text;

	[SerializeField]
	private string locId;

	[SerializeField]
	private string translation;

	[SerializeField]
	private string preffix;

	[SerializeField]
	private string suffix;

	[SerializeField]
	private string[] replaces;

	private void OnEnable()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public string GetFormatedText()
	{
		return "";
	}

	public void Apply()
	{
	}
}
