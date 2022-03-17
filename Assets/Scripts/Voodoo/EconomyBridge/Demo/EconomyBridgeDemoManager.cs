using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Voodoo.EconomyBridge.Demo
{
	public class EconomyBridgeDemoManager : MonoBehaviour
	{
		[Serializable]
		public struct SaveDataStruct
		{
			[Serializable]
			public struct UnlockableStatusStruct
			{
				public string name;

				public bool isLocked;

				public UnlockableStatusStruct(string p_name, bool p_isLocked)
				{
				}
			}

			public int coins;

			public int startBoost;

			public List<UnlockableStatusStruct> skinStatusTable;

			public List<UnlockableStatusStruct> envStatusTable;

			public SaveDataStruct(EconomyBridgeDemoManager manager)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public string placementName;

			internal void _003CStart_003Eb__0()
			{
			}
		}

		public TextMeshProUGUI EconomyDescTmPro;

		public TextMeshProUGUI UnlockablesDescTmPro;

		public GameObject MinigamesButtonsPrefab;

		public Transform MinigamesButtonsParentTf;

		public List<Unlockable> skinUnlockablesList;

		public List<Unlockable> envUnlockablesList;

		private const string RNGFeatureDemoManager_SAVE_KEY = "Voodoo.RNGBridge.Demo.save";

		private const string RNGFeatureDemoManager_INIT_SAVE = "{\"coins\":500,\"startBoost\":5,\"skinStatusTable\":[{\"name\":\"skin1\",\"isLocked\":false},{\"name\":\"skin2\",\"isLocked\":true},{\"name\":\"skin3\",\"isLocked\":true},{\"name\":\"skin4\",\"isLocked\":true}],\"envStatusTable\":[{\"name\":\"env1\",\"isLocked\":false},{\"name\":\"env2\",\"isLocked\":true},{\"name\":\"env3\",\"isLocked\":true},{\"name\":\"env4\",\"isLocked\":true}]}";

		public int coins;

		public int nbStartBoost;

		public Dictionary<string, bool> skinLockStatusDict;

		public Dictionary<string, bool> envLockStatusDict;

		public void Start()
		{
		}

		public void Save()
		{
		}

		public void Load()
		{
		}

		public void RefreshView()
		{
		}

		public void UnlockSkin(string skinName)
		{
		}

		public void UnlockEnv(string envName)
		{
		}
	}
}
