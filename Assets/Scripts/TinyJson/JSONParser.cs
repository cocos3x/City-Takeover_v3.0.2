using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TinyJson
{
	public static class JSONParser
	{
		private static Stack<List<string>> splitArrayPool;

		private static StringBuilder stringBuilder;

		private static Dictionary<Type, Dictionary<string, FieldInfo>> fieldInfoCache;

		private static Dictionary<Type, Dictionary<string, PropertyInfo>> propertyInfoCache;

		public static T FromJson<T>(this string json)
		{
			return (T)null;
		}

		private static int AppendUntilStringEnd(bool appendEscapeCharacter, int startIdx, string json)
		{
			return 0;
		}

		private static List<string> Split(string json)
		{
			return null;
		}

		internal static object ParseValue(Type type, string json)
		{
			return null;
		}

		private static object ParseAnonymousValue(string json)
		{
			return null;
		}

		private static Dictionary<string, T> CreateMemberNameDictionary<T>(T[] members) where T : MemberInfo
		{
			return null;
		}

		private static object ParseObject(Type type, string json)
		{
			return null;
		}
	}
}
