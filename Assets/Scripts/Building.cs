using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Building : MonoBehaviour
{
	public enum FreezeOrigin
	{
		POWER_UP,
		ICE_TORNADO
	}

	public delegate void d_OnCaptured(Building b, BuildingTeam oldTeam, Building fromBuilding);

	public delegate void d_OnResized(Building b);

	private sealed class _003CSpawnAvatar_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Building _003C_003E4__this;

		private Building _003CnextBuilding_003E5__2;

		private int _003CnumberAvatar_003E5__3;

		private float _003CrandomPos_003E5__4;

		private float _003CminTime_003E5__5;

		private float _003CmaxTime_003E5__6;

		private int _003Cn_003E5__7;

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
		public _003CSpawnAvatar_003Ed__102(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public Building _003C_003E4__this;

		public Vector3 _localPos;

		internal void _003CShowReaction_003Eb__0()
		{
		}
	}

	private sealed class _003CIDespawnAvatar_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Avatar avatar;

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
		public _003CIDespawnAvatar_003Ed__106(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass141_0
	{
		public Building _003C_003E4__this;

		public bool show;

		internal void _003CAnimateCrown_003Eb__0()
		{
		}
	}

	private float _score;

	public BuildingTeam team;

	public BuildingType buildingType;

	private int id;

	[SerializeField]
	private bool isMysteryBuilding;

	[SerializeField]
	private bool isFlyingBuilding;

	[SerializeField]
	private LayerMask raycastMask;

	[SerializeField]
	private LayerMask wallMask;

	[SerializeField]
	private GameObject connectionLineTemplate;

	[SerializeField]
	private BuildingUi ui;

	[SerializeField]
	private GameObject avatarPrefab;

	[SerializeField]
	private ParticleSystem conqueredParticle;

	[SerializeField]
	private ParticleSystem coinShowerParticle;

	[SerializeField]
	private MeshRenderer bottom;

	[SerializeField]
	private MeshRenderer top;

	[SerializeField]
	private GameObject midPrefab;

	[SerializeField]
	private List<BuildingMid> mids;

	[SerializeField]
	private List<MeshRenderer> windows;

	[SerializeField]
	private BoxCollider boxCol;

	[SerializeField]
	private ParticleSystem powerUpParticle;

	[SerializeField]
	private ParticleSystem startSizeParticle;

	[SerializeField]
	private GameObject powerUpContainer;

	[SerializeField]
	private GameObject iceAttachmentPrefab;

	[SerializeField]
	private GameObject mysteryAttachmentPrefab;

	[SerializeField]
	private GameObject wingsAttachmentPrefab;

	[SerializeField]
	private GameObject crown;

	[SerializeField]
	private Coin coin;

	[SerializeField]
	private SetMaterialColor arrowSelection;

	[SerializeField]
	private SetMaterialColor snapSelection;

	[SerializeField]
	private SpriteRenderer _reactionEmojiSprite;

	[SerializeField]
	private int startingScore;

	[SerializeField]
	private int maxScore;

	[SerializeField]
	private TMP_Text _goldenTowerTimerText;

	[SerializeField]
	private MeshRenderer _goldenTowerMesh;

	[SerializeField]
	private ParticleSystem _goldenTowerFXPrefab;

	[SerializeField]
	private ParticleSystem _goldenLineFXPrefab;

	private ParticleSystem _goldenTowerActiveBoostFX;

	private Building _goldenTowerConnectedBuilding;

	private List<ParticleSystem> _goldenTowerLineFx;

	private HashSet<FreezeOrigin> _freezeOrigins;

	private bool _003CCanUpdate_003Ek__BackingField;

	private bool _003CImmortal_003Ek__BackingField;

	private int maxConnectionCount;

	private float growthRate;

	private float extraGrowthByConnections;

	private float extraGrowthByHeight;

	private float scoreGrowth;

	private int avatarsSpawned;

	private int avatarsbounced;

	private float powerUpMultiplier;

	private bool hasCoinToGive;

	private bool selectionAvailable;

	private bool snapSelectionAvailable;

	private BuildingAttachmentIce iceEffect;

	private BuildingAttachmentMystery mysteryEffect;

	private BuildingAttachmentWings wings;

	private List<Building> connectedBuildings;

	private List<BuildingConnectionLine> connectionLines;

	private List<Building> buildingsInRange;

	private Tweener _emojiReactionTweener;

	private bool _003C_allowExtraColliderHeight_003Ek__BackingField;

	private bool _collectinCrown;

	public d_OnCaptured OnCaptured;

	public d_OnResized OnResized;

	public int ConnectionCount => 0;

	public int Score => 0;

	public int ID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int StartingScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaxScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsFlying
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsMystery
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanUpdate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Frozen => false;

	public bool Immortal
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool SelectionAvailable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SnapAvailable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool _allowExtraColliderHeight
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void Init()
	{
	}

	private void UpdateMaterial()
	{
	}

	public void UpdateGoldenTowerMaterial()
	{
	}

	private void Update()
	{
	}

	public float GetGrowthTickRate()
	{
		return 0f;
	}

	private void GrowthTick()
	{
	}

	public void GrowStartSize(int increment)
	{
	}

	public IEnumerator SpawnAvatar()
	{
		return null;
	}

	public void OnAvatarArrived(Avatar avatar)
	{
	}

	public void ShowReaction(Sprite _ReactionSprite)
	{
	}

	public void SetTeam(BuildingTeam newTeam)
	{
	}

	private IEnumerator IDespawnAvatar(Avatar avatar)
	{
		return null;
	}

	public void IncreaseScore(float amount)
	{
	}

	public bool AttemptConnectTo(Building newBuilding)
	{
		return false;
	}

	public bool AttemptDisconnectFrom(Building building)
	{
		return false;
	}

	public void DisconnectAll()
	{
	}

	public bool AttemptCut(Vector2 from, Vector2 to)
	{
		return false;
	}

	private void ConnectTo(Building newBuilding)
	{
	}

	private void UpdateConnectionLine(Building from, Building to)
	{
	}

	private void DisconnectFrom(Building b)
	{
	}

	public bool IsConnectedTo(Building b)
	{
		return false;
	}

	public bool CanConnectToMoreBuildings()
	{
		return false;
	}

	public bool CanReachBuilding(Building b)
	{
		return false;
	}

	public bool CanReachSpot(Vector3 spot)
	{
		return false;
	}

	private LayerMask GetMask()
	{
		return (LayerMask)null;
	}

	private Building GetNextConnectedBuilding()
	{
		return null;
	}

	private void UpdateScoreText()
	{
	}

	public void ClearBuildingsInRangeCache()
	{
	}

	public List<Building> GetBuildingsInReach()
	{
		return null;
	}

	public List<Building> GetConnectedBuildingsTo()
	{
		return null;
	}

	private void RefreshConnections()
	{
	}

	public void PlayAllFallBricks()
	{
	}

	public void RefreshHeight(bool attacked)
	{
	}

	private void UpdateReactionEmoji()
	{
	}

	public void RefreshBoxCollider()
	{
	}

	public void ShowTapFinger(bool show)
	{
	}

	public void SetPowerUp(bool powerUp)
	{
	}

	public void TopUp()
	{
	}

	public void SetImmortal(bool immortal)
	{
	}

	public void UnFreeze()
	{
	}

	public void SetFreeze(bool freeze, FreezeOrigin origin)
	{
	}

	public void AnimateCrown(bool show)
	{
	}

	public bool HasCrownToCollect()
	{
		return false;
	}

	public void CollectCrown()
	{
	}

	public BuildingAttachment AddBuildingAttachment(GameObject attachmentPrefab)
	{
		return null;
	}

	public Vector3 GetTopPosition()
	{
		return (Vector3)null;
	}

	public Vector3 GetTopPositionCalculated()
	{
		return (Vector3)null;
	}

	public void JumpAndSpinAnimation(TweenCallback callback)
	{
	}

	public void ShowConnectionsUi(bool show)
	{
	}

	public void DoCoinShowerEffect()
	{
	}

	public void OnGoldenTowerLinked(Building newBuilding)
	{
	}

	public void ActivateGoldenTowerBoost(ParticleSystem linkedFX)
	{
	}

	public void DeactivateGoldenBoost()
	{
	}

	private void _003CCollectCrown_003Eb__143_0()
	{
	}
}
