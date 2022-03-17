using System.Collections.Generic;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo
{
	internal class CrossPromoInfo
	{
		private GameModel _003CCurrentGame_003Ek__BackingField;

		private readonly List<AssetModel> _003CAssets_003Ek__BackingField;

		private readonly List<AssetModel> _003CWaterfall_003Ek__BackingField;

		private readonly List<AssetModel> _003CGamesInstalled_003Ek__BackingField;

		private bool _003CCrossPromoIsReady_003Ek__BackingField;

		private string _003CFormat_003Ek__BackingField;

		public bool HasInternet;

		public GameModel CurrentGame
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<AssetModel> Assets => null;

		public List<AssetModel> Waterfall => null;

		public List<AssetModel> GamesInstalled => null;

		public bool CrossPromoIsReady
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Format
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool GetInternetStatus()
		{
			return false;
		}

		public void FilterAssets()
		{
		}

		public void FillAssetsListFromCache()
		{
		}

		private static void Shuffle<T>(IList<T> list)
		{
		}
	}
}
