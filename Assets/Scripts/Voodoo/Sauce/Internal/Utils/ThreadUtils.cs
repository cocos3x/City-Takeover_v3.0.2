using System.Threading;

namespace Voodoo.Sauce.Internal.Utils
{
	public static class ThreadUtils
	{
		private static Thread _mainThreadID;

		public static bool IsMainThread => false;

		internal static void Init()
		{
		}
	}
}
