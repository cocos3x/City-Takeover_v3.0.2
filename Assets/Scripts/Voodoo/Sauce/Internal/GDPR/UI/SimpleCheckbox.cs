using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.GDPR.UI
{
	public class SimpleCheckbox : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[SerializeField]
		private Sprite _uncheckedSprite;

		[SerializeField]
		private Color _uncheckedColor;

		[SerializeField]
		private Sprite _checkedSprite;

		[SerializeField]
		private bool _initialValue;

		[SerializeField]
		private string _identifier;

		public Toggle.ToggleEvent OnToggle;

		private bool _locked;

		private bool _checked;

		private Image _image;

		private Color _checkedColor;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void Lock(bool value)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void SetChecked(bool value)
		{
		}

		public bool IsChecked()
		{
			return false;
		}

		public void SetDefaultColor(Color color)
		{
		}
	}
}
