using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class WorldMapManager : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public Action callback;

		internal void _003CBlackFade_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public Action callback;

		internal void _003CCameraFocusNode_003Eb__0()
		{
		}
	}

	private sealed class _003CCameraFollowAvatarCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WorldMapManager _003C_003E4__this;

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
		public _003CCameraFollowAvatarCoroutine_003Ed__31(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public WorldMapManager _003C_003E4__this;

		public int levelTarget;

		public Action _003C_003E9__2;

		public TweenCallback _003C_003E9__1;

		internal void _003CStartGame_003Eb__0()
		{
		}

		internal void _003CStartGame_003Eb__1()
		{
		}

		internal void _003CStartGame_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public WorldMapManager _003C_003E4__this;

		public int levelTarget;

		public TweenCallback _003C_003E9__1;

		internal void _003CWinGame_003Eb__0()
		{
		}

		internal void _003CWinGame_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public WorldMapManager _003C_003E4__this;

		public int expulseTo;

		public Action _003C_003E9__1;

		internal void _003CLoseGame_003Eb__0()
		{
		}

		internal void _003CLoseGame_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public WorldMapManager _003C_003E4__this;

		public int levelTarget;

		public Action _003C_003E9__2;

		public TweenCallback _003C_003E9__1;

		internal void _003CUnlockGame_003Eb__0()
		{
		}

		internal void _003CUnlockGame_003Eb__1()
		{
		}

		internal void _003CUnlockGame_003Eb__2()
		{
		}
	}

	private sealed class _003CDragMapCoroutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WorldMapManager _003C_003E4__this;

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
		public _003CDragMapCoroutine_003Ed__52(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public WorldMapManager _003C_003E4__this;

		public int levelTarget;

		public TweenCallback _003C_003E9__2;

		public Action _003C_003E9__3;

		public TweenCallback _003C_003E9__1;

		internal void _003CStartGameStars_003Eb__0()
		{
		}

		internal void _003CStartGameStars_003Eb__1()
		{
		}

		internal void _003CStartGameStars_003Eb__2()
		{
		}

		internal void _003CStartGameStars_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public WorldMapManager _003C_003E4__this;

		public int levelTarget;

		public TweenCallback _003C_003E9__1;

		public TweenCallback _003C_003E9__4;

		public Action _003C_003E9__3;

		public TweenCallback _003C_003E9__2;

		internal void _003CWinGameStars_003Eb__0()
		{
		}

		internal void _003CWinGameStars_003Eb__1()
		{
		}

		internal void _003CWinGameStars_003Eb__2()
		{
		}

		internal void _003CWinGameStars_003Eb__3()
		{
		}

		internal void _003CWinGameStars_003Eb__4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public WorldMapManager _003C_003E4__this;

		public Vector3 targetExpulsePos;

		public int levelTarget;

		public Action _003C_003E9__2;

		public Action _003C_003E9__1;

		internal void _003CLoseGameStars_003Eb__0()
		{
		}

		internal void _003CLoseGameStars_003Eb__1()
		{
		}

		internal void _003CLoseGameStars_003Eb__2()
		{
		}
	}

	public static WorldMapStep WorldMapStep;

	private static WorldMapManager m_Instance;

	[SerializeField]
	private ProgressMapDatas m_Datas;

	[SerializeField]
	private Image m_BlackFadeImage;

	[SerializeField]
	private MeshRenderer[] m_WaterZone;

	private AvatarController _003Cm_Avatar_003Ek__BackingField;

	private Dictionary<int, MapNode> m_Nodes;

	private GameManager m_Gm;

	private Camera m_MainCamera;

	private Transform m_MainCameraTransform;

	private bool m_FollowAvatar;

	private Coroutine CameraFollowAvatarCoroutine_Instance;

	private int mapViewStartNodeLevel;

	private int mapViewEndNodeLevel;

	private const float MAPVIEW_CAMERA_DRAG_SMOOTH_FACTOR = 0.1f;

	private const float MAPVIEW_DRAG_SCREEN_FACTOR = -1f;

	private const float EXPULSION_RATIO = 0.5f;

	private Vector3 mapView_CameraPosMin;

	private Vector3 mapView_CameraPosMax;

	private Vector3 mapView_CameraTargetPos;

	private Quaternion mapView_targetCameraAngle;

	private float mapView_CameraCurrentProgress;

	private Coroutine _dragMapCoroutine_instance;

	private int _sectionStartNodeLevel;

	private int _sectionLockedLevel;

	public static WorldMapManager Instance => null;

	public AvatarController m_Avatar
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public ProgressMapDatas Datas => null;

	private bool FollowAvatar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void BlackFade(bool show, float duration, [Optional] Action callback)
	{
	}

	private void SetupWaterMaterial(int level)
	{
	}

	private void InitMap()
	{
	}

	private MapNode GenerateNode(int level)
	{
		return null;
	}

	public void CameraShopFocus(bool open)
	{
	}

	private void CameraFocusNode(int level, bool isLarge, bool smooth = true, Ease ease = Ease.InOutSine, [Optional] Action callback)
	{
	}

	private void ChangeFov(int value, bool smooth = true, Ease ease = Ease.InOutSine)
	{
	}

	private IEnumerator CameraFollowAvatarCoroutine()
	{
		return null;
	}

	public void OnButtonStart()
	{
	}

	public void StartGame()
	{
	}

	public void WinGame()
	{
	}

	public void LoseGame()
	{
	}

	public void UnlockGame()
	{
	}

	public void DisplayAsMap()
	{
	}

	public void DisplayAsHome()
	{
	}

	public IEnumerator DragMapCoroutine()
	{
		return null;
	}

	public void OnDragMap(float dragScreenAmount)
	{
	}

	public void SelectMapLevel(MapNode mapNode)
	{
	}

	public void OnUnlockNextSection()
	{
	}

	public void StartGameStars()
	{
	}

	public void WinGameStars()
	{
	}

	public void LoseGameStars()
	{
	}

	public void OnButtonStartStars()
	{
	}

	public void OnReplayLevels()
	{
	}

	private void _003COnButtonStart_003Eb__32_0()
	{
	}

	private void _003COnButtonStart_003Eb__32_1()
	{
	}

	private void _003COnButtonStart_003Eb__32_2()
	{
	}

	private void _003COnUnlockNextSection_003Eb__55_0()
	{
	}

	private void _003COnButtonStartStars_003Eb__59_0()
	{
	}

	private void _003COnButtonStartStars_003Eb__59_1()
	{
	}
}
