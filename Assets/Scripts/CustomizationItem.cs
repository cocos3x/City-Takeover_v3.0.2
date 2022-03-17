using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CustomizationItem : MonoBehaviour
{
	[Serializable]
	public class MaterialMap
	{
		public BuildingTeam team;

		public Material mat;
	}

	private sealed class _003CIDelayMat_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomizationItem _003C_003E4__this;

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
		public _003CIDelayMat_003Ed__10(int _003C_003E1__state)
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

	private BuildingTeam _003CTeam_003Ek__BackingField;

	[SerializeField]
	private Renderer rend;

	[SerializeField]
	private List<MaterialMap> materialMaps;

	private Material originalMat;

	private Material matChoice;

	public BuildingTeam Team
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (BuildingTeam)null;
		}
		private set
		{
		}
	}

	public void SetTeam(BuildingTeam team)
	{
	}

	private IEnumerator IDelayMat()
	{
		return null;
	}

	public void SetSkinMeshGuide(SkinnedMeshRenderer skinGuide)
	{
	}

	public void EnableShadows(bool enable)
	{
	}
}
