using UnityEngine;
using UnityEngine.UI;

namespace GameWorthy
{
	public class GameWorthySplashScreen : MonoBehaviour
	{
		[SerializeField]
		private int sceneToLoad;

		[SerializeField]
		private Image logo;

		[SerializeField]
		private Image text;

		[SerializeField]
		private Image fade;

		[SerializeField]
		private GameObject gdprContainer;

		private void Start()
		{
		}

		private void OnPresentationComplete()
		{
		}

		private void LoadNextScene()
		{
		}

		public void _OnAcceptClicked()
		{
		}

		public void _OnPrivacyPolicyClicked()
		{
		}
	}
}
