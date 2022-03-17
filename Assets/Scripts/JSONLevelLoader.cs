using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class JSONLevelLoader : MonoBehaviour
{
	public struct SwitchedBuildingData
	{
		public BuildingTeam Team;

		public int StartingScore;

		public int MaxScore;

		public int Id;

		public bool IsMystery;

		public bool IsFlying;
	}

	private sealed class _003CGenerateBots_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelLayout _LevelLayout;

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
		public _003CGenerateBots_003Ed__9(int _003C_003E1__state)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<int> _003C_003E9__12_0;

		public static Func<Building, bool> _003C_003E9__15_0;

		internal bool _003CGenerateGoldenTower_003Eb__12_0(int x)
		{
			return false;
		}

		internal bool _003CSwitchAllBuildings_003Eb__15_0(Building building)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public string skinId;

		internal bool _003CGetBuildingSkin_003Eb__0(CustomizationBuildingData x)
		{
			return false;
		}
	}

	[SerializeField]
	private Building _neutralBuilding;

	[SerializeField]
	private Building _attackBuilding;

	[SerializeField]
	private Building _defenceBuilding;

	[SerializeField]
	private Building _attackDefenceBuilding;

	[SerializeField]
	private Building _goldenBuilding;

	[SerializeField]
	private GameObject _obstacle;

	private void Start()
	{
	}

	private void GenerateLevel()
	{
	}

	private IEnumerator GenerateBots(LevelLayout _LevelLayout)
	{
		return null;
	}

	private void GenerateObstacles(LevelLayout _LevelLayout)
	{
	}

	private void GenerateBuildings(LevelLayout _LevelLayout)
	{
	}

	private void GenerateGoldenTower(LevelLayout _LevelLayout)
	{
	}

	private Building GetBuildingSkin(BuildingType type, BuildingTeam team)
	{
		return null;
	}

	private Building GetBuildingClassicSkin(BuildingType type)
	{
		return null;
	}

	private void SwitchAllBuildings(List<Building> _TeamBuildings)
	{
	}

	private void SwitchBuilding(Building _FromBuilding, Building _ToBuilding)
	{
	}

	private SwitchedBuildingData GetBuildingDatas(Building from)
	{
		return (SwitchedBuildingData)null;
	}
}
