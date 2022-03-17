using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.EconomyBridge.Demo
{
	public class EconomyBridgeDemo : EconomyBridgeBase
	{
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public string unlockableId;

			internal bool _003C_FindUnlockableById_003Eb__0(Unlockable u)
			{
				return false;
			}
		}

		public EconomyBridgeDemoManager manager;

		private Camera _mainCamBackup;

		private Unlockable _FindUnlockableById(List<Unlockable> unlockableList, string unlockableId)
		{
			return null;
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

		public override void ShowMainScene()
		{
		}
	}
}
