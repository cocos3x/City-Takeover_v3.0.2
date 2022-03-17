using UnityEngine;
using Voodoo.Pattern.Random;
using VoodooPackages.Tech;

public class BattleModeManager : SingletonMB<BattleModeManager>
{
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public BuildingTeam _Team;

		internal bool _003CUpdatePosition_003Eb__0(PlayerDescription description)
		{
			return false;
		}
	}

	[SerializeField]
	private PseudoPool _pseudoPool;

	[SerializeField]
	private FlagPool _flagPool;

	[SerializeField]
	private BattleModeData _battleModeData;

	[SerializeField]
	private EmojiData _emojiData;

	[SerializeField]
	private GameObject _arena;

	[SerializeField]
	private GameObject _avatar;

	private BattleModeAvatarAnimation _battleModeAvatarAnimation;

	private PlayerDescription[] _playerDescriptions;

	private int _playerCount;

	private float _currentBattleModeValue;

	private int _currentVictoryInARowCount;

	private int _currentDefeatInARowCount;

	private GameUi _gameUI;

	private PlayerDescription _playerDescription;

	private int _playerLeftCount;

	public EmojiData EmojiData => null;

	public PlayerDescription[] PlayerDescriptions => null;

	public int PlayerCount => 0;

	public float CurrentBattleModeValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int UnlockedLevel => 0;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void ProcessBattleModeAnimation()
	{
	}

	private void OnGameModeChanged(EGameMode _GameMode)
	{
	}

	public void OnStartButtonPressed()
	{
	}

	private void GeneratePlayersDescription(LevelDescription _LevelDescription)
	{
	}

	public void OnLevelFailed()
	{
	}

	private void OnLevelCompleted(EGameMode _GameMode)
	{
	}

	private void OnLevelSkipped(EGameMode _GameMode)
	{
	}

	private void IncreaseVictoryBattleModeValue()
	{
	}

	private void IncreaseDefeatBattleModeValue()
	{
	}

	public void ChangePlayerName(string _Name)
	{
	}

	public Sprite GetMedalByPosition(int _Position)
	{
		return null;
	}

	public void Reset()
	{
	}

	public void UpdatePosition(BuildingTeam _Team)
	{
	}

	protected override void OnDestroySpecific()
	{
	}

	private void _003COnStartButtonPressed_003Eb__30_0()
	{
	}
}
