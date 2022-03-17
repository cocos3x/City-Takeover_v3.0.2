using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.EnvironmentSettings;
using Voodoo.Sauce.Internal.VoodooTune;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugEnvironmentScreen : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			public Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Server buttonServer;

			public DebugEnvironmentScreen _003C_003E4__this;

			internal void _003CInitVoodooTuneServerButtons_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public VoodooTuneClusterApi.ConfigVersion buttonConfigVersion;

			public DebugEnvironmentScreen _003C_003E4__this;

			internal void _003CInitVoodooTuneVersionButtons_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Server buttonServer;

			public DebugEnvironmentScreen _003C_003E4__this;

			internal void _003CInitAnalyticsServerButtons_003Eb__0()
			{
			}
		}

		[SerializeField]
		private DebugPopup _debugPopup;

		[SerializeField]
		private DebugCheckableSection _voodooTuneSection;

		[SerializeField]
		private Button[] _voodooTuneServerButtons;

		[SerializeField]
		private Image[] _voodooTuneServerCheckBoxes;

		[SerializeField]
		private Button[] _voodooTuneVersionButtons;

		[SerializeField]
		private Image[] _voodooTuneVersionCheckBoxes;

		[SerializeField]
		private DebugCheckableSection _analyticsSection;

		[SerializeField]
		private Button[] _analyticsServerButtons;

		[SerializeField]
		private Image[] _analyticsServerCheckBoxes;

		[SerializeField]
		private InputField _proxyServerTextField;

		private const string NewServerMessage = "Your {0} server is set to {1}, restart the application to apply the modifications.";

		private static readonly Dictionary<Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Server, string> _serverDictionary;

		private const string NewVoodooTuneVersionMessage = "Your VoodooTune version is set to {0}, restart the application to apply the modifications.";

		private static readonly Dictionary<VoodooTuneClusterApi.ConfigVersion, string> _voodooTuneVersionDictionary;

		private Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Server _voodooTuneServer;

		private Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Server _analyticsServer;

		private VoodooTuneClusterApi.ConfigVersion _voodooTuneVersion;

		private void Start()
		{
		}

		private void InitProxyServerSection()
		{
		}

		private void InitVoodooTuneSection()
		{
		}

		private void InitVoodooTuneServerButtons()
		{
		}

		private void InitAnalyticsSection()
		{
		}

		private void InitVoodooTuneVersionButtons()
		{
		}

		private void InitAnalyticsServerButtons()
		{
		}

		private void SelectServer(Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Server server, Voodoo.Sauce.Internal.EnvironmentSettings.EnvironmentSettings.Api api)
		{
		}

		private void SelectVoodooTuneVersion(VoodooTuneClusterApi.ConfigVersion voodooTuneVersion)
		{
		}

		private void _003CSelectServer_003Eb__24_0()
		{
		}

		private void _003CSelectVoodooTuneVersion_003Eb__25_0()
		{
		}
	}
}
