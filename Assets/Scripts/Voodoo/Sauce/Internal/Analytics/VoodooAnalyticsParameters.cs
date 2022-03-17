namespace Voodoo.Sauce.Internal.Analytics
{
	public class VoodooAnalyticsParameters
	{
		private readonly bool _003CUseVoodooTune_003Ek__BackingField;

		private readonly bool _003CUseVoodooAnalytics_003Ek__BackingField;

		private readonly string _003CEditorIdfa_003Ek__BackingField;

		private readonly string _003CProxyServer_003Ek__BackingField;

		public bool UseVoodooTune => false;

		public bool UseVoodooAnalytics => false;

		public string EditorIdfa => "";

		public string ProxyServer => "";

		public VoodooAnalyticsParameters(bool useVoodooTune, bool useVoodooAnalytics, string editorIdfa, string proxyServer)
		{
		}
	}
}
