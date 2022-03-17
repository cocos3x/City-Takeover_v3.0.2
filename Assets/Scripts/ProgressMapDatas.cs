using UnityEngine;

public class ProgressMapDatas : ScriptableObject
{
	public MapNode _Nodes;

	public GameObject _Road;

	public int _RangeLevelGeneration;

	public int _SpacingX;

	public int _SpacingY;

	public Vector2 _MultiplicatorOffsetLeftRight;

	public float _NodeRotRight;

	public float _NodeRotLeft;

	public int _NodeGroupRange;

	public Vector2 _MultiplicatorChangeGroup;

	public int _NodeDifferenceAtStart;

	public float _DelayBeforeFocusAtStart;

	public float _TransitionDuration;

	public float _MapTransitionDuration;

	public Vector3 _TargetNodePositionOffset;

	public Vector3 _TargetNodeLargePositionOffset;

	public Vector3 _TargetNodeMapPositionOffset;

	public Vector3 _TargetNodeRotationOffset;

	public Vector3 _TargetNodeLargeRotationOffset;

	public Vector3 _TargetNodeMapRotationOffset;

	public int _DefaultFov;

	public int _LargeFov;

	public Vector3 _ShopPositionOffset;

	public Vector3 _ShopRotationOffset;

	public Vector3 _AvatarPositionOffset;

	public Vector3 _AvatarRotationOffset;

	public float _AvatarSpeed;

	public int _NextRegionEvery;

	public ProgressMapRegionDatas[] _RegionDatas;
}
