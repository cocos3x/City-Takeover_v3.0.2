using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugAdsScreen : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static UnityAction _003C_003E9__16_0;

			public static UnityAction _003C_003E9__16_1;

			public static UnityAction _003C_003E9__16_2;

			public static UnityAction _003C_003E9__16_3;

			public static UnityAction _003C_003E9__16_4;

			public static UnityAction _003C_003E9__16_5;

			public static UnityAction _003C_003E9__16_6;

			internal void _003CAwake_003Eb__16_0()
			{
			}

			internal void _003CAwake_003Eb__16_1()
			{
			}

			internal void _003CAwake_003Eb__16_2()
			{
			}

			internal void _003CAwake_003Eb__16_3()
			{
			}

			internal void _003CAwake_003Eb__16_4()
			{
			}

			internal void _003CAwake_003Eb__16_5()
			{
			}

			internal void _003CAwake_003Eb__16_6()
			{
			}
		}

		[SerializeField]
		private Button _showFSButton;

		[SerializeField]
		private Button _showRVButton;

		[SerializeField]
		private Text _bannerInformation;

		[SerializeField]
		private Text _interstitialConditionsStatusText;

		[SerializeField]
		private Text _interstitialConditionStatusInfoText;

		[SerializeField]
		private Text _interstitialDisplaySettingsText;

		[SerializeField]
		private Button _showMediationDebuggerButton;

		[SerializeField]
		private Button _showPrimaryFSButton;

		[SerializeField]
		private Text _PrimaryFSInformation;

		[SerializeField]
		private Button _showSecondaryFSButton;

		[SerializeField]
		private Text _SecondaryFSInformation;

		[SerializeField]
		private Button _showPrimaryRVButton;

		[SerializeField]
		private Text _PrimaryRVInformation;

		[SerializeField]
		private Button _showSecondaryRVButton;

		[SerializeField]
		private Text _SecondaryRVInformation;

		private const string AdInformation = "Loading Time: {0} \nNetwork: {1}";

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void UpdateButton(Button button, bool adAvailable)
		{
		}

		private void UpdateText(Text text, double loadingTime, string adNetwork)
		{
		}

		private string FormatInformation(double loadingTime, string adNetwork)
		{
			return "";
		}
	}
}
