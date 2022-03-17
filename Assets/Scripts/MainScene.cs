using UnityEngine;

public class MainScene : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public string skinId;

		internal bool _003CRefreshBuilding_003Eb__0(CustomizationBuildingData x)
		{
			return false;
		}
	}

	[SerializeField]
	private Avatar avatar;

	[SerializeField]
	private GameObject building;

	[SerializeField]
	private Camera cam;

	[SerializeField]
	private Transform avatarCameraTarget;

	private Transform originalCameraTarget;

	private GameManager manager;

	private CustomizationManager customization;

	private GameUi gameUi;

	private void Start()
	{
	}

	private void RefreshAvatar()
	{
	}

	private void RefreshBuilding()
	{
	}

	private void OnCustomizationMenuOpened()
	{
	}

	private void OnCustomizationMenuClosed()
	{
	}

	private void SubToUiEvents()
	{
	}

	private void UnsubToUiEvents()
	{
	}

	private void OnDestroy()
	{
	}
}
