using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugLogsScreen : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public int value;

			public DebugLogsScreen _003C_003E4__this;

			internal void _003CAwake_003Eb__2(bool b)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<object, string> _003C_003E9__9_1;

			public static Func<object, string> _003C_003E9__9_0;

			internal string _003CAwake_003Eb__9_1(object o)
			{
				return "";
			}

			internal string _003CAwake_003Eb__9_0(object o)
			{
				return "";
			}
		}

		[SerializeField]
		private Toggle _enableLogsToggle;

		[SerializeField]
		private GameObject _restartLogsView;

		[SerializeField]
		private Dropdown _logLevelDropdown;

		[SerializeField]
		private RectTransform _logFilterContainer;

		[SerializeField]
		private Toggle _logFilterPrefab;

		[SerializeField]
		private GameObject _logFilterParent;

		private string[] _logModuleNames;

		private Toggle[] _logFilterToggles;

		private bool _originalLogsEnabled;

		private void Awake()
		{
		}

		private string FormatModuleName(string module)
		{
			return "";
		}

		private void OnLogModuleChanged(int value)
		{
		}

		private void OnLogLevelChanged(int value)
		{
		}

		private void OnEnableLogsToggled(bool enableLogs)
		{
		}
	}
}
