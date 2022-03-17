using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Voodoo.Sauce.Internal.DebugScreen;

public class SDKListScreen : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public object o;

		internal bool _003CInstantiateInfo_003Eb__0(FieldInfo f)
		{
			return false;
		}
	}

	[SerializeField]
	private Transform _content;

	[SerializeField]
	private DebugCheckableSection _sectionPrefab;

	[SerializeField]
	private GameObject _autoResizableTextPrefab;

	private static List<string> _ignoredFields;

	private void Start()
	{
	}

	private void InstantiateInfo(object o, string name, DebugCheckableSection parent)
	{
	}
}
