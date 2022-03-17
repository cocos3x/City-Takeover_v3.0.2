using System.Collections.Generic;
using UnityEngine;

public class GameObjectActivator : MonoBehaviour
{
	private static List<GameObjectActivator> _allGameObjectsActivators;

	private static List<string> _activeKeys;

	public string key;

	public List<GameObject> objectsToActivate;

	public List<GameObject> objectsToDeactivate;

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public static void ApplyActivationForKey(string key)
	{
	}

	private void _ApplyActivation()
	{
	}
}
