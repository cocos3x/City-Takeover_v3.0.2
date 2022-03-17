using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Models
{
	[Serializable]
	public class GameModel
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<AssetModel, string> _003C_003E9__6_0;

			internal string _003CGetPromotedAssetsNames_003Eb__6_0(AssetModel asset)
			{
				return "";
			}
		}

		public string id;

		public string name;

		public AssetModel[] promote_assets;

		public int first_time_videos_in_cache;

		public int buffer_videos;

		public string os_type;

		public string GetPromotedAssetsNames()
		{
			return "";
		}
	}
}
