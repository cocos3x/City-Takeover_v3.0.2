using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.VoodooTune;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugVoodooTuneScreen : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public DebugVoodooTuneScreen _003C_003E4__this;

			public DebugCheckableSection noneSection;

			internal void _003CInstantiateAllConfigs_003Eb__0(bool check)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public VoodooTuneNode node;

			public DebugVoodooTuneScreen _003C_003E4__this;
		}

		private sealed class _003C_003Ec__DisplayClass24_1
		{
			public DebugCheckableSection section;

			public _003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals1;

			internal void _003CInstantiateConfigNode_003Eb__0(bool check)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public DebugCheckableSection clusterSection;

			public DebugVoodooTuneScreen _003C_003E4__this;

			public string clusterId;

			public UnityAction _003C_003E9__1;

			internal void _003COnCheckCluster_003Eb__0(bool succeed)
			{
			}

			internal void _003COnCheckCluster_003Eb__1()
			{
			}
		}

		private const string VOODOO_TUNE_HIERARCHY_ERROR = "An error occured, can't retrieve datas. \n Please Verify you have access to internet.";

		private const string NEW_VOODOO_TUNE_MESSAGE = "Your new configuration is set to {0}, restart the application to apply the modifications.";

		private const string NEW_VOODOO_TUNE_ERROR = "An error occured, the new configuration has not been set. \n Please Verify you have access to internet.";

		[SerializeField]
		private GameObject _loadingScreen;

		[SerializeField]
		private Transform _content;

		[SerializeField]
		private DebugCheckableSection _sectionPrefab;

		[SerializeField]
		private GameObject _autoResizableTextPrefab;

		[SerializeField]
		private DebugTextPair _copyVoodooTuneJson;

		[SerializeField]
		private DebugTextPair _copyVoodooTuneUrl;

		[SerializeField]
		private InputField _localTimeoutField;

		[SerializeField]
		private Text _initializeInfoText;

		[SerializeField]
		private Image _initializeIndicatorImage;

		private string _clusterId;

		private VoodooTuneNode _voodooTuneRoot;

		private DebugCheckableSection _clusterSection;

		private void OnEnable()
		{
		}

		private void UpdateInitializeInfoText()
		{
		}

		private string GetResponseName(double httpCode)
		{
			return "";
		}

		private void ResizeContent()
		{
		}

		private void OnVoodooTuneHierarchyRetrieved(VoodooTuneNode root)
		{
		}

		private void InstantiateLocalConfig()
		{
		}

		private DebugCheckableSection CreateSection(string name, DebugCheckableSection parentSection)
		{
			return null;
		}

		private string FindClusterName(string id, VoodooTuneNode node)
		{
			return "";
		}

		private void InstantiateAllConfigs()
		{
		}

		private void InstantiateConfigNode(VoodooTuneNode parentNode, DebugCheckableSection parentSection, DebugCheckableSection clustersSection, DebugCheckableSection abTestsSection)
		{
		}

		private void OnCheckCluster(string clusterId, DebugCheckableSection clusterSection)
		{
		}

		private static string FormatConfigTitle(string title)
		{
			return "";
		}

		private static string FormatConfigValue(string value)
		{
			return "";
		}

		public void OnEndEdit(string value)
		{
		}

		private void _003COnVoodooTuneHierarchyRetrieved_003Eb__19_0()
		{
		}
	}
}
