using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.PlaneModeFighter.Demo
{
	public class PlaneModeFighterTest : MonoBehaviour
	{
		public enum EnumGameState
		{
			Loading,
			MainMenu,
			Playing,
			Paused
		}

		private EnumGameState _003CgameState_003Ek__BackingField;

		private EnumGameState _displayedGameState;

		[SerializeField]
		private Text _gameStateText;

		[SerializeField]
		private Text _IsPremiumText;

		[SerializeField]
		private Text _elapsedTimeText;

		[SerializeField]
		private Text _gameCountText;

		[SerializeField]
		private GameObject _viewsParent;

		[SerializeField]
		private GameObject _loadingParent;

		private float _elapsedTime;

		public EnumGameState gameState
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (EnumGameState)null;
			}
			private set
			{
			}
		}

		private void Start()
		{
		}

		private void _DisplayLoadingUIorAppUI(bool isLoadingUI)
		{
		}

		private void _OnInitFinishedEvent()
		{
		}

		public void OnStartGameGate_BtnClicked()
		{
		}

		private void _OnGameStarted()
		{
		}

		public void OnVoodooDebug_BtnClicked()
		{
		}

		public void OnEndGame_BtnClicked()
		{
		}

		public void _OnGamePause()
		{
		}

		public void _OnGameUnpause()
		{
		}

		public void ChangeGameStateTo(EnumGameState newGameState)
		{
		}

		public void Update()
		{
		}
	}
}
