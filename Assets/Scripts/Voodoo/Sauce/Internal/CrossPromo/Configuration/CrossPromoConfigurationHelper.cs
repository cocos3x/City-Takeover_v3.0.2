using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.Configuration
{
	internal class CrossPromoConfigurationHelper
	{
		internal enum ShouldBeShownReason
		{
			CanBeShown,
			SessionTooEarly,
			SessionCooldown,
			GameTooEarly,
			GameCooldown,
			TooMuchImpressions,
			NotEnabled
		}

		private CrossPromoConfiguration _configuration;

		private int _impressionsCount;

		private int _lastSessionCountWhenShown;

		private int _lastGamePlayedWhenShown;

		private int _gamesPlayed;

		private bool _crossPromoEnabled;

		private int _currentSessionCooldown;

		private const string K_PREFS_LAST_SESSION_SHOWN = "CrossPromo_LastSessionShown";

		private int LastSessionCountWhenShown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int SessionCount => 0;

		private int GameCount => 0;

		internal void Initialize(CrossPromoConfiguration configuration, bool crossPromoEnabled)
		{
		}

		internal bool ShouldBeEnabled()
		{
			return false;
		}

		internal ShouldBeShownReason GetShouldBeShownReason()
		{
			//IL_0003: Expected I4, but got O
			return (ShouldBeShownReason)null;
		}

		internal bool ShouldBeShown()
		{
			return false;
		}

		internal string GetGamesToShow()
		{
			return "";
		}

		private void OnClick(AssetModel obj)
		{
		}

		private void OnShown(AssetModel obj)
		{
		}

		private void OnGamePlayed(int level, bool victory)
		{
		}

		internal string GetCurrentStateDebugText()
		{
			return "";
		}

		internal string GetCurrentConfigurationDebugText()
		{
			return "";
		}

		internal string GetWaterfallId()
		{
			return "";
		}
	}
}
