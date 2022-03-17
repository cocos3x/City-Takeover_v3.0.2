using DG.Tweening;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Voodoo.EconomyBridge;

namespace Voodoo.RNGWheel
{
	public class RNGWheelSlice : MonoBehaviour
	{
		public string rewardType;

		public RNGRewardsRemoteConfig.RewardGroup[] rewardGroups;

		public GameObject rewardContainer;

		public GameObject rewardGrantedContainer;

		public GameObject unlockableRewardGrantedContainer;

		public TextMeshProUGUI rewardAmountTMPro;

		public TextMeshProUGUI rewardGrantedAmountTMPro;

		public GameObject slotBG;

		public GameObject slotBar;

		public Material slotOddMat;

		public Material slotEvenMat;

		public Material slotHighlightMat;

		public int rewardIndex;

		public Reward reward;

		public float startAnglePos;

		private static Dictionary<string, Mesh> resizedSliceMeshes;

		private GameObject _slotBGHighlight;

		private MeshRenderer _slotBGHighlightMR;

		private Sequence _highlightSequence;

		private Vector3 _rewardContainerInitScale;

		private const float _QUICK_HIGHLIGHT_ALPHA = 0.75f;

		private const float _QUICK_HIGHLIGHT_IN_DURATION = 0.05f;

		private const float _QUICK_HIGHLIGHT_OUT_DURATION = 0.1f;

		private const float _QUICK_HIGHLIGHT_PRIZE_BUMP_SCALE = 1.025f;

		private const float _BLINK_HIGHLIGHT_ALPHA = 1f;

		private const float _BLINK_OFF_ALPHA = 0.1f;

		private const float _BLINK_HIGHLIGHT_IN_DURATION = 0.05f;

		private const float _BLINK_HIGHLIGHT_OUT_DURATION = 0.1f;

		private const float _FINALBLINK_HIGHLIGHT_ALPHA = 1f;

		private const float _FINALBLINK_HIGHLIGHT_IN_DURATION = 0.05f;

		private const float _FINALBLINK_HIGHLIGHT_OUT_DURATION = 0.3f;

		private const float _FINALBLINK_HIGHLIGHT_PRIZE_BUMP_SCALE = 1.1f;

		public void Awake()
		{
		}

		public Mesh GenerateRadialScaledMesh(float originalAngle, float targetAngle)
		{
			return null;
		}

		public static RNGWheelSlice InstantiateSliceFromPrefab(GameObject slicePrefab, Transform slicesParent, int rewardIndex, Reward reward, float currentStartAngle, float sliceAngle)
		{
			return null;
		}

		public void QuickHighlight()
		{
		}

		public void GrantRewardHighlight()
		{
		}

		private void _RewardGrantedAnim()
		{
		}

		public void StopHighlight()
		{
		}

		private void _003CQuickHighlight_003Eb__27_0()
		{
		}

		private void _003CQuickHighlight_003Eb__27_1()
		{
		}

		private void _003CGrantRewardHighlight_003Eb__36_0()
		{
		}

		private void _003CGrantRewardHighlight_003Eb__36_1()
		{
		}
	}
}
