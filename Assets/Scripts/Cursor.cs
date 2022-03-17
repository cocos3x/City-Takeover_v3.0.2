using UnityEngine;

public class Cursor : MonoBehaviour
{
	[SerializeField]
	private BuildingTeam team;

	[SerializeField]
	private LayerMask buildingLayer;

	[SerializeField]
	private Transform fromCircle;

	[SerializeField]
	private Transform toCircle;

	[SerializeField]
	private Renderer fromToLine;

	[SerializeField]
	private TrailRenderer cutTrail;

	private GameUi gameUi;

	private LevelManager levelManager;

	private bool updateInput;

	private bool canInput;

	private Building fromBuilding;

	private Building toBuilding;

	private Vector3 lastCursorPos;

	private Color canColor;

	private Color cantColor;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Init(LevelManager _levelManager, GameUi _gameUi)
	{
	}

	public void OnInputDown()
	{
	}

	public void OnInputUp()
	{
	}

	public void FirstDown()
	{
	}

	public void InputUpdate()
	{
	}

	public void FirstUp()
	{
	}

	private void OnDestroy()
	{
	}

	public void UnsubFromInput()
	{
	}

	private void ShowFromToline(bool show)
	{
	}

	private void SetCirclePosition(Transform circle, Vector3 toPos)
	{
	}

	private void SetCutTrailPosition(Vector3 pos)
	{
	}

	private void AttemptCutSegments(Vector3 from, Vector3 to)
	{
	}

	private (Building, Vector3) InputCheck()
	{
		return ((Building, Vector3))null;
	}

	private void _003CAwake_003Eb__15_0()
	{
	}

	private void _003CAwake_003Eb__15_1()
	{
	}

	private void _003COnDestroy_003Eb__24_0()
	{
	}

	private void _003COnDestroy_003Eb__24_1()
	{
	}
}
