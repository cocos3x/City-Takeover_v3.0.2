using System.Collections.Generic;

namespace VoodooPackages.Tech.ExtensionMethodsList
{
	public static class ExtensionMethodsList
	{
		public static void Swap<T>(this List<T> _List, int _FirstIndex, int _SecondIndex)
		{
		}

		public static void SwapRange<T>(this List<T> _List, int _BaseFirstIndex, int _BaseSecondIndex, int _DestFirstIndex, int _DestSecondIndex)
		{
		}

		public static void Shuffle<T>(this List<T> _List)
		{
		}

		public static void Shift<T>(this List<T> _List, int _Offset)
		{
		}

		public static T GetRandomValue<T>(this List<T> _List)
		{
			return (T)null;
		}

		public static bool ContainsAll<T>(this List<T> source, List<T> values)
		{
			return false;
		}
	}
}
