using System;
using UnityEngine;

namespace MTLTownTakeover
{
	public class TownTakeoverMigrator : MonoBehaviour
	{
		private class PlayerSave
		{
			public int highestLevelProgress;

			public int currentLevel;

			public int coins;

			public bool onboardingEnded;

			public bool isPremium;
		}

		public void CheckMigrate(Action onComplete)
		{
		}
	}
}
