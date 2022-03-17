using System;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.CrossPromo.Models
{
	[Serializable]
	public class AssetModel
	{
		public int id;

		public string file_path;

		public string file_url;

		public string tracking_link;

		public string tracking_impression;

		public string cp_format;

		public GameToPromote game;

		public CrossPromoAnalyticsInfo ToAnalyticsModel()
		{
			return (CrossPromoAnalyticsInfo)null;
		}
	}
}
