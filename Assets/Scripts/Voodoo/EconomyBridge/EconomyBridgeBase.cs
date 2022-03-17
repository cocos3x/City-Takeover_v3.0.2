using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Voodoo.EconomyBridge
{
	public abstract class EconomyBridgeBase : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public RewardConfig nextRewardConfig;

			internal bool _003CGetRewardsForDrawConfig_003Eb__0(Reward r)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public Reward reward;

			internal bool _003CGenerateUnlockableIdForReward_003Eb__0(Unlockable u)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass13_1
		{
			public Reward generatedReward;

			internal bool _003CGenerateUnlockableIdForReward_003Eb__1(Unlockable u)
			{
				return false;
			}
		}

		private sealed class _003C_LaunchMinigameSceneCoroutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string sceneName;

			public LoadSceneMode mode;

			public EconomyBridgeBase _003C_003E4__this;

			private AsyncOperation _003CasyncLoad_003E5__2;

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
			public _003C_LaunchMinigameSceneCoroutine_003Ed__33(int _003C_003E1__state)
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

		public List<RewardConfig> rewardConfigList;

		private List<Reward> _generatedRewardList;

		private RNGRewardsRemoteConfig _rngRewardsRemoteConfig;

		private Dictionary<RNGRewardsRemoteConfig.RewardGroup, List<RewardConfig>> _rewardConfigDict;

		private RNGMinigamesRemoteConfig _remoteConfig;

		public string minigameSceneName;

		public bool isMinigameRunning;

		public RNGMinigamesRemoteConfig.PlacementInfo placementInfo;

		private Action _onMinigameComplete;

		private Coroutine _LaunchMinigameSceneCoroutineInstance;

		private static EconomyBridgeBase _instance;

		private static object _lock;

		private static bool _isQuitting;

		public RNGMinigamesRemoteConfig remoteConfig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static EconomyBridgeBase Instance => null;

		public RewardConfig GetRewardConfigById(string rewardConfigId)
		{
			return null;
		}

		public Reward GetReward(RNGRewardsRemoteConfig.DrawType drawType)
		{
			return null;
		}

		public Reward GetRewardFromList(RNGRewardsRemoteConfig.DrawType drawType, List<Reward> availableRewards)
		{
			return null;
		}

		private Reward _CreateRewardFromConfig(RewardConfig rewardConfig)
		{
			return null;
		}

		public List<Reward> GetRewardsForDrawConfig(RNGRewardsRemoteConfig.DrawType drawType, int nbRewardsInList, bool duplicateConfigsAllowed = true)
		{
			return null;
		}

		protected void _InitRewardConfigDict()
		{
		}

		public void SetGeneratedRewardList(List<Reward> generatedRewardList)
		{
		}

		public void ResetGeneratedRewardsList()
		{
		}

		public List<Reward> UpdateGeneratedRewardList()
		{
			return null;
		}

		public void GenerateUnlockableIdForReward(Reward reward)
		{
		}

		protected void ForceReplaceConfigForType(string rewardType)
		{
		}

		public void Awake()
		{
		}

		public abstract void HideMainScene();

		public abstract void ShowMainScene();

		public abstract void OnRewardGranted(Reward reward);

		public abstract List<Unlockable> GetUnlockables(string rewardType);

		public abstract Unlockable GetUnlockableById(string rewardType, string unlockableId);

		public abstract bool IsRewardTypeUnlockable(string rewardType);

		public abstract void ShowMinigame(string placementName, Action onComplete);

		protected void _LaunchMinigameScene(string sceneName, LoadSceneMode mode, Action onComplete, RNGMinigamesRemoteConfig.PlacementInfo p_placementInfo)
		{
		}

		private IEnumerator _LaunchMinigameSceneCoroutine(string sceneName, LoadSceneMode mode)
		{
			return null;
		}

		public void MinigameComplete()
		{
		}

		public void OnApplicationQuit()
		{
		}
	}
}
