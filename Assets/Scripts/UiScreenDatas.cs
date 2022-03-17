using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class UiScreenDatas : ScriptableObject
{
	[Serializable]
	private struct UiScreenVariant
	{
		public string _AbVarName;

		public BaseScreenUi _VariantScreen;
	}

	[Serializable]
	private class UiScreensGroup
	{
		public BaseScreenUi _UiScreensDefault;

		public UiScreenVariant[] _Variants;
	}

	[Serializable]
	private sealed class _003C_003Ec__3<T>
	{
		public static readonly _003C_003Ec__3<T> _003C_003E9;

		public static Func<UiScreensGroup, bool> _003C_003E9__3_0;

		internal bool _003CGetOrCreateScreen_003Eb__3_0(UiScreensGroup ui)
		{
			return false;
		}
	}

	[SerializeField]
	private UiScreensGroup[] m_Screens;

	public T GetOrCreateScreen<T>(ref T screen, [Optional] Transform parent)
	{
		return (T)null;
	}
}
