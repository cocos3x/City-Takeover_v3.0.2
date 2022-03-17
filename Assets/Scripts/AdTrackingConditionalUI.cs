using UnityEngine;
using Voodoo.Sauce.Internal.GDPR.UI;

public class AdTrackingConditionalUI : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _objectsDisabledIfAdTracking;

	[SerializeField]
	private GameObject[] _objectsDisabledIfNotAdTracking;

	[SerializeField]
	private SimpleCheckbox[] _checkboxesLockedIfAdTracking;

	private void Start()
	{
	}
}
