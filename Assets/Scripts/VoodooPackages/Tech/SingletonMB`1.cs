using UnityEngine;

namespace VoodooPackages.Tech
{
	public class SingletonMB<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		private static object _lock;

		private static bool _isQuitting;

		public static T Instance => null;

		public static void SetActive(bool _Active)
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void OnApplicationQuit()
		{
		}

		protected virtual void OnDestroySpecific()
		{
		}
	}
}
