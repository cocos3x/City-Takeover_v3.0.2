using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class MapNode : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public Action callback;

		internal void _003CBumpNode_003Eb__0()
		{
		}
	}

	private ProgressMapRegionDatas m_RegionDatas;

	private NodeEnvironment m_Environment;

	private int _003Cm_Level_003Ek__BackingField;

	private int _003Cm_NbStarsEarned_003Ek__BackingField;

	private bool _003Cm_IsLocked_003Ek__BackingField;

	[SerializeField]
	private SlotLevelBuilding[] m_SlotLevelBuildings;

	[SerializeField]
	private Renderer m_BaseRenderer;

	[SerializeField]
	private NodeEnvironment[] m_Island;

	[SerializeField]
	private ParticleSystem m_UnlockParticles;

	[SerializeField]
	private TextMeshPro m_LevelText;

	[SerializeField]
	private GameObject m_Star1empty;

	[SerializeField]
	private GameObject m_Star2empty;

	[SerializeField]
	private GameObject m_Star3empty;

	[SerializeField]
	private GameObject m_Star1full;

	[SerializeField]
	private GameObject m_Star2full;

	[SerializeField]
	private GameObject m_Star3full;

	[SerializeField]
	private GameObject m_SectionLock;

	public int m_Level
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int m_NbStarsEarned
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public bool m_IsLocked
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public ProgressMapRegionDatas RegionDatas => null;

	private int GetDir(int level)
	{
		return 0;
	}

	private NodeEnvironment GetIslandIndex(int level)
	{
		return null;
	}

	public void UpdateNode(int level)
	{
	}

	public void UnlockLevel()
	{
	}

	public void LockLevel()
	{
	}

	public void SetSectionLockActive(bool active)
	{
	}

	public void SetColorNode(bool unlockedColor)
	{
	}

	public void BumpNode(float duration, float strength, int vibrato, [Optional] Action callback)
	{
	}

	public void BumpCantSelectNode()
	{
	}

	public void BumpSelectNode()
	{
	}
}
