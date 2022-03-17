using System;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.GDPR.UI;

public class VoodooGDPRPrivacyScreen : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SimpleCheckbox, bool> _003C_003E9__8_0;

		public static Func<SimpleCheckbox, bool> _003C_003E9__8_1;

		public static Func<SimpleCheckbox, bool> _003C_003E9__8_2;

		public static Func<SimpleCheckbox, bool> _003C_003E9__8_3;

		internal bool _003CUpdateButtonsAvailability_003Eb__8_0(SimpleCheckbox box)
		{
			return false;
		}

		internal bool _003CUpdateButtonsAvailability_003Eb__8_1(SimpleCheckbox box)
		{
			return false;
		}

		internal bool _003CUpdateButtonsAvailability_003Eb__8_2(SimpleCheckbox box)
		{
			return false;
		}

		internal bool _003CUpdateButtonsAvailability_003Eb__8_3(SimpleCheckbox box)
		{
			return false;
		}
	}

	[SerializeField]
	private SimpleCheckbox[] _checkboxesRequiredForPlaying;

	[SerializeField]
	private SimpleCheckbox[] _checkboxesRequiredForPlayingAfterInfoScreenSeen;

	[SerializeField]
	private SimpleCheckbox[] _checkboxesRequiredForLearnMore;

	[SerializeField]
	private SimpleCheckbox[] _checkboxesRequiredForPlayingWithoutAdTracking;

	[SerializeField]
	private Button _playBtn;

	[SerializeField]
	private Button _learnMoreBtn;

	private bool _infoPageHasBeenSeen;

	private void Start()
	{
	}

	private void UpdateButtonsAvailability()
	{
	}

	public void ThingsToDoWhenInfoIsShown()
	{
	}

	public void OnSDKInfoClick()
	{
	}

	public void OnAdsInfoClick()
	{
	}

	public void OnAnalyticsInfoClick()
	{
	}

	public void OnAgeInfoClick()
	{
	}

	public void OnInfoClick()
	{
	}

	private void _003CStart_003Eb__6_0(bool c)
	{
	}

	private void _003CStart_003Eb__6_1(bool c)
	{
	}
}
