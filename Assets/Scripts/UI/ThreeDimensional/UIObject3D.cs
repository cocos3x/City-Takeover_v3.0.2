using System;
using UnityEngine;

namespace UI.ThreeDimensional
{
	public class UIObject3D : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass69_0
		{
			public UIObject3D _003C_003E4__this;

			public Color color;

			public Action _003C_003E9__3;

			internal void _003CStart_003Eb__0()
			{
			}

			internal void _003CStart_003Eb__1()
			{
			}

			internal void _003CStart_003Eb__2()
			{
			}

			internal void _003CStart_003Eb__3()
			{
			}
		}

		[SerializeField]
		private Transform _ObjectPrefab;

		[SerializeField]
		private Vector3 _TargetRotation;

		[SerializeField]
		private float _TargetOffsetX;

		[SerializeField]
		private float _TargetOffsetY;

		[SerializeField]
		private bool _OverrideCalculatedTargetScale;

		[SerializeField]
		private float _CalculatedTargetScaleOverride;

		[SerializeField]
		private float _CameraFOV;

		[SerializeField]
		private float _CameraDistance;

		[SerializeField]
		private bool _AlwaysLookAtTarget;

		[SerializeField]
		private Vector2 _textureSize;

		[SerializeField]
		private Color _BackgroundColor;

		[SerializeField]
		public bool LimitFrameRate;

		[SerializeField]
		public float FrameRateLimit;

		public bool RenderConstantly;

		[SerializeField]
		private float _RenderScale;

		private float timeSinceLastRender;

		[SerializeField]
		private bool _EnableCameraLight;

		[SerializeField]
		private Color _LightColor;

		[SerializeField]
		private float _LightIntensity;

		[NonSerialized]
		private bool started;

		[NonSerialized]
		private bool hardUpdateQueued;

		[NonSerialized]
		private bool renderQueued;

		[NonSerialized]
		private Bounds targetBounds;

		private RectTransform _rectTransform;

		[SerializeField]
		private UIObject3DImage _imageComponent;

		private Texture2D _texture2D;

		private Sprite _sprite;

		private RenderTexture _renderTexture;

		private static Transform _parentContainer;

		private Transform _container;

		private Transform _targetContainer;

		private Transform _target;

		private Camera _targetCamera;

		private Light _cameraLight;

		private int _objectLayer;

		public Transform ObjectPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 TargetRotation
		{
			get
			{
				return (Vector3)null;
			}
			set
			{
			}
		}

		[SerializeField]
		public Vector2 TargetOffset
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public bool OverrideCalculatedTargetScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float CalculatedTargetScaleOverride
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CameraFOV
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CameraDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool AlwaysLookAtTarget
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 TextureSize => (Vector2)null;

		public Color BackgroundColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public float RenderScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float timeBetweenFrames => 0f;

		public bool EnableCameraLight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color LightColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public float LightIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected RectTransform rectTransform => null;

		public UIObject3DImage imageComponent => null;

		protected Texture2D texture2D => null;

		protected Sprite sprite => null;

		protected RenderTexture renderTexture => null;

		private static Transform parentContainer => null;

		protected Transform container => null;

		protected Transform targetContainer => null;

		protected Transform target => null;

		protected Camera targetCamera => null;

		protected Light cameraLight => null;

		protected int objectLayer => 0;

		public void DestroyResources()
		{
		}

		public void HardUpdateDisplay()
		{
		}

		private void _Destroy(UnityEngine.Object o)
		{
		}

		private void Start()
		{
		}

		public void SetStarted()
		{
		}

		public void UpdateDisplay(bool instantRender = false)
		{
		}

		private void OnEnable()
		{
		}

		private void ClearObjectLayerFromCameras()
		{
		}

		private void ClearObjectLayerFromLights()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Prepare()
		{
		}

		public void Cleanup()
		{
		}

		public Transform GetTargetInstance()
		{
			return null;
		}

		private void Render(bool instant = false)
		{
		}

		private void Update()
		{
		}

		private void SetupTarget()
		{
		}

		public void RefreshTarget()
		{
		}

		private void UpdateTargetPositioningAndScale()
		{
		}

		private void SetLayerRecursively(Transform transform, int layer)
		{
		}

		private void SetupTargetCamera()
		{
		}

		private void SetupCameraLight()
		{
		}

		private void UpdateTargetCameraPositioningEtc()
		{
		}

		private void _003CHardUpdateDisplay_003Eb__67_0()
		{
		}

		private void _003COnEnable_003Eb__72_0()
		{
		}

		private void _003CRefreshTarget_003Eb__110_0()
		{
		}
	}
}
