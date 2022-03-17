using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleModePlayerDescription : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _pseudoTxt;

	[SerializeField]
	private Image _flag;

	[SerializeField]
	private Image _background;

	[SerializeField]
	private Outline _backgroundOutline;

	[SerializeField]
	private PlayerDescriptionMedal _medalParent;

	public void Init(PlayerDescription _Description)
	{
	}

	public void SetMedal(Sprite _Sprite, int _Position)
	{
	}
}
