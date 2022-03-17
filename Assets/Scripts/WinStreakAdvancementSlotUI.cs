using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinStreakAdvancementSlotUI : MonoBehaviour
{
	[SerializeField]
	private TMP_Text floorRewardText;

	[SerializeField]
	private TMP_Text goldRewardText;

	[SerializeField]
	private Image fillImage;

	[SerializeField]
	private Image selectedImage;

	[SerializeField]
	private ParticleSystem selectedPS;

	public void Init(int floorReward, float goldReward, bool isSelected)
	{
	}

	public void AnimateFill(int delay)
	{
	}

	private void _003CAnimateFill_003Eb__6_0()
	{
	}
}
