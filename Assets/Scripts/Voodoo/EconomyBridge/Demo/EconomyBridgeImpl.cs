using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.EconomyBridge.Demo
{
	public class EconomyBridgeImpl : EconomyBridgeBase
	{
		private const int MINIMUM_TIMEBEFOREUSE_FOR_POWERS_TO_BE_OFFERED = 60;

		public UnlockableViewBase UnlockableBodyCustomizationView;

		public UnlockableViewBase UnlockableHeadCustomizationView;

		public UnlockableViewBase UnlockableShieldCustomizationView;

		public UnlockableViewBase UnlockableSwordCustomizationView;

		private Dictionary<string, Dictionary<string, Unlockable>> _allUnlockables;

		private List<RewardConfig> _originalRewardConfigList;

		private Camera _mainCamBackup;

		private List<BaseScreenUi> previousScreenList;

		public new void Awake()
		{
		}

		private void _AddToAllUnlockablesDict(Customization customization, UnlockableViewBase prefab, string type)
		{
		}

		public override void OnRewardGranted(Reward reward)
		{
		}

		public override List<Unlockable> GetUnlockables(string rewardType)
		{
			return null;
		}

		public override Unlockable GetUnlockableById(string rewardType, string unlockableId)
		{
			return null;
		}

		public override bool IsRewardTypeUnlockable(string rewardName)
		{
			return false;
		}

		public override void ShowMinigame(string placementName, Action onComplete)
		{
		}

		public override void HideMainScene()
		{
		}

		private void _UpdateRewardsForPowerUps()
		{
		}

		private List<RewardConfig> DuplicateRewardConfigList(List<RewardConfig> srcRewardConfig)
		{
			return null;
		}

		public override void ShowMainScene()
		{
		}
	}
}
