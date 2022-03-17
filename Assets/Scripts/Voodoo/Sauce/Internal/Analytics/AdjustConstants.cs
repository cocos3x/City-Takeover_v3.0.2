using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal static class AdjustConstants
	{
		internal static readonly int[] GameCountsToTrack;

		internal static readonly HashSet<string> TestDeviceIdfas;

		internal const string BannerClickedEventName = "banner_click";

		internal const string FSClickedEventName = "fs_click";

		internal const string RVClickedEventName = "rv_click";

		internal const string FSShownEventName = "fs_shown";

		internal const string RVShownEventName = "rv_shown";

		internal const string GamePlayedEventName = "_games_played";

		internal const string CustomEventName = "custom_event";

		internal const string CustomEventParameterName = "custom_event_name";

		internal const string AppSubVersionParameterName = "app_subversion";

		internal const string VoodooSauceParameterName = "vs_version";
	}
}
