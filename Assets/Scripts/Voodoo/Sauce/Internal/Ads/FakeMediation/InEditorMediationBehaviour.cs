using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	public class InEditorMediationBehaviour : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__12_3;

			internal void _003CAwake_003Eb__12_3()
			{
			}
		}

		[SerializeField]
		private BannerVideoAd _bannerVideoAd;

		[SerializeField]
		private InEditorAd _interstitialAd;

		private Action _onInterstitialClosed;

		[SerializeField]
		private InEditorAd _rewardedAd;

		[SerializeField]
		private Button _closeWithRewardButton;

		private Action<bool> _onRewardedClose;

		private string _rewardedType;

		private string _interstitialType;

		private float _prevTimeScale;

		public event Action<bool> OnRewardedVideoAvailabilityChangeEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void ShowBanner()
		{
		}

		public void HideBanner()
		{
		}

		private void PauseTime()
		{
		}

		private void ResumeTime()
		{
		}

		public void ShowInterstitial(Action onComplete, [Optional] string adTag)
		{
		}

		public void ShowRewarded(Action<bool> onComplete, [Optional] string adTag)
		{
		}

		private void _003CAwake_003Eb__12_1()
		{
		}

		private void _003CAwake_003Eb__12_2()
		{
		}

		private void _003CAwake_003Eb__12_4()
		{
		}

		private void _003CAwake_003Eb__12_5()
		{
		}

		private void _003CAwake_003Eb__12_0()
		{
		}
	}
}
