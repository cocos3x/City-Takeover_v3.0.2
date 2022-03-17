using System;
using System.Runtime.InteropServices;
using VoodooPackages.Tech;

public class PowerUpManager : SingletonMB<PowerUpManager>
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public bool _fullTuto;

		public TutorialStep _Step;

		public PowerButton _powerButton;

		public PowerUpManager _003C_003E4__this;

		public GameManager manager;

		public Action _003C_003E9__2;

		internal void _003CShowTutorial_003Eb__0()
		{
		}

		internal void _003CShowTutorial_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_1
	{
		public BuildingTeam targetTeam;

		internal bool _003CShowTutorial_003Eb__1(Building buildingData)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public PowerUpManager _003C_003E4__this;

		public PowerButton _Button;

		public TutorialStep _Step;

		internal void _003COnButtonUsed_003Eb__0()
		{
		}
	}

	private PowerBar _powerBar;

	private Action _tutorialCallback;

	public static event Action EventOnTutorialShowed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action EventOnTutorialComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public void RegisterBar(PowerBar _Bar)
	{
	}

	public void OnLevelStarted()
	{
	}

	private void ShowTutorial(TutorialStep _Step, bool _fullTuto = false, [Optional] PowerButton _powerButton)
	{
	}

	public void OnRestart()
	{
	}

	private void OnButtonUsed(PowerButton _Button, TutorialStep _Step)
	{
	}
}
