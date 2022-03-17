using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugMixpanelABTestsScreen : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public DebugMixpanelABTestsScreen _003C_003E4__this;

			public string abTestName;

			internal void _003CCreateCohortButton_003Eb__0()
			{
			}
		}

		private const string NO_COHORT = "NO_COHORT";

		[SerializeField]
		private GameObject _cohortButtonPrefab;

		[SerializeField]
		private Transform _contentParent;

		[SerializeField]
		private Text _currentCohortText;

		[SerializeField]
		private Text _restartGameText;

		[SerializeField]
		private Text _cohortSizeText;

		private void Awake()
		{
		}

		private void SetUpCohortButtons(VoodooSettings settings)
		{
		}

		private void CreateCohortButton(string abTestName)
		{
		}

		private void SetAbTest(string abTestName)
		{
		}

		private void OnEnable()
		{
		}
	}
}
