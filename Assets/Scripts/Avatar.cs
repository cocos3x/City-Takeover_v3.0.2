using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class Avatar : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public Avatar _003C_003E4__this;

		public TweenCallback callback;

		internal void _003CLand_003Eb__0()
		{
		}
	}

	private sealed class _003CIKill_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Avatar _003C_003E4__this;

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
		public _003CIKill_003Ed__58(int _003C_003E1__state)
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

	private BuildingTeam _003Cteam_003Ek__BackingField;

	private BuildingType _003Ctype_003Ek__BackingField;

	private bool _003CHasSword_003Ek__BackingField;

	private bool _003CHasShield_003Ek__BackingField;

	[SerializeField]
	private Collider col;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private LayerMask castMask;

	[SerializeField]
	private Transform headParent;

	[SerializeField]
	private Transform bodyParent;

	[SerializeField]
	private Transform backpackParent;

	[SerializeField]
	private WieldingObject swordParent;

	[SerializeField]
	private WieldingObject shieldParent;

	[SerializeField]
	private SkinnedMeshRenderer bodyGuide;

	[SerializeField]
	private GameObject wingPrefab;

	[SerializeField]
	private GameObject menuFakeShadow;

	private CustomizationItem head;

	private CustomizationItem body;

	private CustomizationItem sword;

	private CustomizationItem shield;

	private GameObject wing;

	private Building fromBuilding;

	private Building targetBuilding;

	private int bouncesAllowed;

	private int bounces;

	private bool alive;

	private bool landing;

	private float collisionCheckTimer;

	private bool flying;

	private static readonly int AttackMode;

	public BuildingTeam team
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (BuildingTeam)null;
		}
		set
		{
		}
	}

	public BuildingType type
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (BuildingType)null;
		}
		private set
		{
		}
	}

	public bool HasSword
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool HasShield
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public Animator Animator => null;

	public Building FromBuilding => null;

	public void Init(BuildingTeam newTeam, BuildingType newType, Building fromBuilding, Building toBuilding, AvatarCustomizaion customizaion)
	{
	}

	public void SetVisual(BuildingTeam visualTeam, AvatarCustomizaion customizaion)
	{
	}

	private void AttemptDespawnCustomizationItem(CustomizationItem item, string id)
	{
	}

	private CustomizationItem SpawnCustomizationItem(Customization customization, string id, Transform parent)
	{
		return null;
	}

	private void Update()
	{
	}

	private void Duel(Avatar other)
	{
	}

	private void DowngradeType()
	{
	}

	private void MoveToBuilding(Building newBuilging)
	{
	}

	public void Bounce(Building from, Building building)
	{
	}

	public void Fly()
	{
	}

	public void Land(float height, [Optional] TweenCallback callback)
	{
	}

	public bool CanBounce()
	{
		return false;
	}

	public void Kill()
	{
	}

	private IEnumerator IKill()
	{
		return null;
	}

	private void RefreshSwordAndShiledVisual()
	{
	}

	public void Dance()
	{
	}

	public void SetModeAttack(bool _Active)
	{
	}

	public void ActivateMenuFakeShadow(bool _Active)
	{
	}

	private void _003CUpdate_003Eb__49_0()
	{
	}
}
