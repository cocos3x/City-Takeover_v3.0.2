using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AirshipController : MonoBehaviour
{
	private enum AirshipStateEnum
	{
		HIDDEN,
		ONBOARD,
		COLLECTED
	}

	[Serializable]
	private struct TrajectoryPoint
	{
		public Vector3 position;

		public float rotationY;

		public float travelTimeFromPrevious;
	}

	[Serializable]
	public struct RewardPrefab
	{
		public string name;

		public GameObject prefab;
	}

	private sealed class _003C_AirshipDropCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AirshipController _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_AirshipDropCoroutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public float previousVolume;

		public AirshipController _003C_003E4__this;

		internal void _003CUpdate_003Eb__0()
		{
		}
	}

	[SerializeField]
	private GameObject airshipVisualsContainer;

	[SerializeField]
	private GameObject airshipCollectEffect;

	[SerializeField]
	private Vector3[] airshipPathStartPoints;

	[SerializeField]
	private Vector3[] airshipPathEndPoints;

	[SerializeField]
	private Vector3[] airshipPathRotation;

	[SerializeField]
	private float airshipSpeed;

	[SerializeField]
	private Canvas touchMeCallToActionCanvas;

	[SerializeField]
	private RectTransform touchMeCallToActionRT;

	[SerializeField]
	private RewardPrefab[] rewardPrefabsList;

	private Dictionary<string, GameObject> _rewardPrefabsDict;

	private AirshipStateEnum airshipState;

	private LevelManager _lm;

	private int _totalInactivityTimeForNextDrop;

	private float _nextDropMinTime;

	private Camera _mainCam;

	private const string NB_AIRSHIPS_COLECTED_KEY = "NbAirshipsCollected";

	private int _NbAirshipsCollected;

	private RaycastHit[] _raycastHits;

	private bool _listenForClick;

	private int NbAirshipsCollected
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Start()
	{
	}

	private IEnumerator _AirshipDropCoroutine()
	{
		return null;
	}

	public void OnAirShipCollected()
	{
	}

	public void Update()
	{
	}

	private void OnAirShipLeft()
	{
	}

	private bool IsNextAirShipFree()
	{
		return false;
	}

	private void _003COnAirShipCollected_003Eb__25_0()
	{
	}

	private void _003COnAirShipCollected_003Eb__25_1()
	{
	}
}
