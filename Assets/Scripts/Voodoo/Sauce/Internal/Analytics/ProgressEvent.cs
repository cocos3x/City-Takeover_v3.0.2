using GameAnalyticsSDK;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class ProgressEvent : GameAnalyticsEvent
	{
		private readonly GAProgressionStatus _status;

		private readonly string _progress;

		private readonly int? _score;

		protected override void PerformTrackEvent()
		{
		}

		public ProgressEvent(GAProgressionStatus status, string progress, int? score)
		{
		}
	}
}
