using TMPro;
using UnityEngine;

public class CoinContainerUi : BaseScreenUi
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public int coinsFinished;

		public CoinContainerUi _003C_003E4__this;

		internal void _003CAnimateAmound_003Eb__0(float f)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_1
	{
		public RectTransform newCoin;

		public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;

		internal void _003CAnimateAmound_003Eb__1()
		{
		}
	}

	[SerializeField]
	private TMP_Text coinText;

	[SerializeField]
	private GameObject coinPrefab;

	[SerializeField]
	private Transform toCoinAnchor;

	private int previousCoins;

	public override void OnOpen()
	{
	}

	public void SetAmount(int coins, bool animate = false)
	{
	}

	public void AnimateAmound(Vector3 fromPos, int fromCoins, int toCoins, bool showLess = true, float radiusTmin = 0.2f, float radiusTmax = 0.25f)
	{
	}

	private void _003CSetAmount_003Eb__5_0(float f)
	{
	}
}
