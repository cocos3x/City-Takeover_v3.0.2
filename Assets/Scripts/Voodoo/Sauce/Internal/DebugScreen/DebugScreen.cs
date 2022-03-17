using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugScreen : MonoBehaviour
	{
		internal enum TextStyle
		{
			normal,
			warning
		}

		[SerializeField]
		private GameObject _sectionHeaderPrefab;

		[SerializeField]
		private DebugTextPair _textPairPrefab;

		[SerializeField]
		private GameObject _separatorPrefab;

		[SerializeField]
		private Transform _contentParent;

		private DebugHideableSection currentHideableSection;

		internal void CreateSpace()
		{
		}

		internal void CreateHeader(string headerText)
		{
		}

		internal void CreateTextPair(string key, string value, bool showCopyButton = true, TextStyle style = TextStyle.normal)
		{
		}

		internal void CreateSeparator()
		{
		}

		internal void ClearDisplay()
		{
		}
	}
}
