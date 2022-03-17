using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugHideableSection : MonoBehaviour
	{
		[SerializeField]
		private Button buttonShowHide;

		[SerializeField]
		private Image showHideImage;

		[SerializeField]
		private Sprite collapseSprite;

		[SerializeField]
		private Sprite expandSprite;

		private readonly List<GameObject> children;

		private bool isShown;

		private void Awake()
		{
		}

		public void AddChild(GameObject child)
		{
		}

		private void SetChildrenVisibility(bool show)
		{
		}

		private void _003CAwake_003Eb__6_0()
		{
		}
	}
}
