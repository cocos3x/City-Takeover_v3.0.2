using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HazardManager : MonoBehaviour
{
	public enum HazardType
	{
		NONE,
		METEOR_SHOWER,
		ICE_TORNADO,
		THUNDER_STORM
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		private sealed class _003C_003CStartMeteorShower_003Eg__Finish_007C0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public _003C_003Ec__DisplayClass43_0 _003C_003E4__this;

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
			public _003C_003CStartMeteorShower_003Eg__Finish_007C0_003Ed(int _003C_003E1__state)
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

		public float showerDuration;

		public HazardManager _003C_003E4__this;

		internal IEnumerator _003CStartMeteorShower_003Eg__Finish_007C0()
		{
			return null;
		}
	}

	private sealed class _003CLaunchMeteor_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public HazardManager _003C_003E4__this;

		public Vector3 position;

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
		public _003CLaunchMeteor_003Ed__46(int _003C_003E1__state)
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

	private sealed class _003CLaunchMeteor_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public HazardManager _003C_003E4__this;

		public Building target;

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
		public _003CLaunchMeteor_003Ed__47(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public Building building;

		internal bool _003CStartThunderStorm_003Eb__0(int x)
		{
			return false;
		}
	}

	private HazardType _currentHazardType;

	private float _timeBeforeNextHazard;

	public bool IsProtected;

	public GameObject ProtectionPrefab;

	private Dictionary<Building, GameObject> Shields;

	public GameObject TornadoPrefab;

	public float _tornadoSpeed;

	public float TornadoFreezeRadius;

	public float TornadoFreezeDuration;

	private GameObject _tornado;

	private Vector3 _tornadoStartPosition;

	private Vector3 _tornadoEndPosition;

	private float _tornadoAppearXMin;

	private float _tornadoAppearXMax;

	private float _tornadoAppearZMin;

	private float _tornadoAppearZMax;

	private float _tornadoFreezeNextUpdate;

	private Dictionary<Building, float> _tornadoFrozenBuildingTimeLeft;

	public HazardMeteor MeteorPrefab;

	private List<Vector3> _meteorMissedPositions;

	private float _meteorAppearXMin;

	private float _meteorAppearXMax;

	private float _meteorAppearZMin;

	private float _meteorAppearZMax;

	public HazardThunder ThunderPrefab;

	public int NumberThunders;

	private List<HazardThunder> _thundersList;

	private bool _hasHazardOnCurrentLevel;

	public HazardType Hazard => (HazardType)null;

	public float TimeBeforeHazard => 0f;

	public bool IsWaitingForHazard => false;

	public bool IsHazardActive => false;

	public void Init()
	{
	}

	private void SelectNextHazard()
	{
	}

	private void StartHazardEffect()
	{
	}

	private void StopHazardEffect()
	{
	}

	private void Update()
	{
	}

	private void UpdateProtection()
	{
	}

	private void StartMeteorShower()
	{
	}

	private void StopMeteorShower()
	{
	}

	private void UpdateMeteorShower()
	{
	}

	private IEnumerator LaunchMeteor(Vector3 position, float delay)
	{
		return null;
	}

	private IEnumerator LaunchMeteor(Building target, float delay)
	{
		return null;
	}

	private void StartIceTornado()
	{
	}

	private void StopIceTornado()
	{
	}

	private void CheckIceTornadoEnd()
	{
	}

	private void UpdateIceTornado()
	{
	}

	public void OnDrawGizmos()
	{
	}

	private void StartThunderStorm()
	{
	}

	private void StopThunderStorm()
	{
	}

	private void UpdateThunderStorm()
	{
	}
}
