using System.Collections.Generic;
using VoodooPackages.Tech;

namespace Voodoo.GameOps
{
	public class QualityTuner : SingletonMB<QualityTuner>
	{
		private const string QUALITY_LEVEL_KEY = "Voodoo.GameOps.QualityTuner.QualityLevel";

		private QualityTunerConfig _remoteConfig;

		private float _minFrameTimeThreshold;

		private float _maxFrameTimeThreshold;

		private float _nextCheckCountDown;

		private float _startTime;

		private int _nbFramesUnderLowerFPS;

		private int _nbFramesOverUpperFPS;

		private int _nbFramesTotalInWindow;

		private List<VoodooSauce.AnalyticsProvider> _analyticsProviders;

		private void Awake()
		{
		}

		private void _VSInitialized()
		{
		}

		private void _UpdateRemoteConfig()
		{
		}

		public void OnDestroy()
		{
		}

		public void Update()
		{
		}

		private void _EndFrameRateCheckWindow()
		{
		}
	}
}
