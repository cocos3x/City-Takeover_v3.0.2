using System.Collections.Generic;

namespace CTO.Analytics
{
	public static class AnalyticsManager
	{
		public static int s_GameCount;

		public static void SendEvent(AnalyticsData _Data)
		{
		}

		public static void OnGameFinished(bool levelComplete, float score, string levelNumber, Dictionary<string, object> _EventProperties)
		{
		}

		public static void OnGameStart(string levelNumber, Dictionary<string, object> _EventProperties)
		{
		}
	}
}
