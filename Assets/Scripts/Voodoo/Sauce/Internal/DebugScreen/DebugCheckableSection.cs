using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugCheckableSection : MonoBehaviour
	{
		[SerializeField]
		private Button _checkbox;

		[SerializeField]
		private Image _checkmark;

		[SerializeField]
		private Text _headerTitle;

		[SerializeField]
		private Toggle _expandCollapseButton;

		[SerializeField]
		private Image _expandImage;

		[SerializeField]
		private Image _collapseImage;

		[SerializeField]
		private Transform _container;

		private bool _isCheckboxToggleable;

		private UnityAction<bool> _onCheckEvent;

		public Transform Container => null;

		public void Initialize(string title, bool isCheckable = false, bool isCheck = false, bool isCheckboxToggleable = true, [Optional] UnityAction<bool> onCheckEvent)
		{
		}

		public void SetTitle(string title)
		{
		}

		public void AddToSection(Transform transform)
		{
		}

		public void Check()
		{
		}

		public void Uncheck()
		{
		}

		private void OnCheckboxClick()
		{
		}

		private void OnExpandCollapseClick(bool selection)
		{
		}

		private static void RefreshHierarchySize(Transform transform)
		{
		}
	}
}
