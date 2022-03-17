using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Analytics
{
	internal static class AnalyticsUtil
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<string, object>, string> _003C_003E9__0_0;

			internal string _003CConvertDictionaryToJson_003Eb__0_0(KeyValuePair<string, object> d)
			{
				return "";
			}
		}

		internal static string ConvertDictionaryToJson(Dictionary<string, object> eventCustomData, [Optional] string dataJson, [Optional] string customVariables)
		{
			return "";
		}

		private static bool ValidateJson(string json)
		{
			return false;
		}

		internal static string ConvertDictionaryToCustomVarJson(Dictionary<string, object> eventCustomVariables)
		{
			return "";
		}

		public static void AddParameterEnum(ref Dictionary<string, object> data, string key, Enum variable, string defaultValue)
		{
		}

		public static void AddParameterString(ref Dictionary<string, object> data, string key, string variable)
		{
		}

		public static void AddParameterNullable<T>(ref Dictionary<string, object> data, string key, T? variable) where T : struct
		{
		}
	}
}
