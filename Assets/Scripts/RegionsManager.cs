using UnityEngine;

public class RegionsManager : MonoBehaviour
{
	public enum VisualRegion
	{
		FOREST,
		BEACH,
		ICE,
		LAVA,
		DESERT,
		COUNT
	}

	private VisualRegion _003CCurrentRegion_003Ek__BackingField;

	public int NEW_REGION_COST;

	public int LEVELS_PER_REGION;

	public static RegionsManager Instance;

	private GameObject regionGmo;

	private GameObject lights;

	[SerializeField]
	private Sprite[] regionIcons;

	[SerializeField]
	private GameObject[] regionPrefabs;

	public VisualRegion CurrentRegion
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (VisualRegion)null;
		}
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void Init()
	{
	}

	public int NextEnvironment()
	{
		return 0;
	}

	public void LoadNextEnvironment()
	{
	}

	public void ClearRegion()
	{
	}

	public void LoadEnvironment(VisualRegion newEnvironment)
	{
	}

	public void ShowRegion(bool show)
	{
	}

	public Sprite GetRegionIcon(VisualRegion region)
	{
		return null;
	}

	public VisualRegion GetNextVisualRegion(VisualRegion region)
	{
		//IL_0003: Expected I4, but got O
		return (VisualRegion)null;
	}

	public VisualRegion CalculateCurrentRegionByLevel(int level)
	{
		//IL_0003: Expected I4, but got O
		return (VisualRegion)null;
	}

	public float GetCompletionT(int level)
	{
		return 0f;
	}

	public int GetFirstRegionLevel(int currentLevel)
	{
		return 0;
	}

	private void TrackRegionUnlocked(int _RegionIndex)
	{
	}
}
