using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	internal class VoodooTune
	{
		[Serializable]
		private sealed class _003C_003Ec__15<T> where T : class, new()
		{
			public static readonly _003C_003Ec__15<T> _003C_003E9;

			public static Func<Type, bool> _003C_003E9__15_0;

			internal bool _003CGetSubclassesItems_003Eb__15_0(Type myType)
			{
				return false;
			}
		}

		private const string TAG = "VoodooTune";

		private const string DefaultFolder = "DefaultJsons/";

		private Dictionary<Type, List<object>> _configurations;

		private Dictionary<string, string> _jsonConfigurations;

		internal static string GetSegmentationUuid()
		{
			return "";
		}

		internal static string GetAbTestUuid()
		{
			return "";
		}

		internal static string GetAbTestCohortName()
		{
			return "";
		}

		internal static string GetAbTestCohortUuid()
		{
			return "";
		}

		internal static string GetAbTestVersionUuid()
		{
			return "";
		}

		internal static string GetClusterId()
		{
			return "";
		}

		internal static bool GetDebuggerAuthorization()
		{
			return false;
		}

		internal static bool HasCache()
		{
			return false;
		}

		internal void LoadLocalConfigurations()
		{
		}

		internal void SaveConfig(string config)
		{
		}

		internal void SaveAndRefreshConfig(string config)
		{
		}

		internal List<T> GetSubclassesItems<T>() where T : class, new()
		{
			return null;
		}

		internal List<T> GetItems<T>() where T : class, new()
		{
			return null;
		}

		internal List<T> GetItemsOrDefaults<T>() where T : class, new()
		{
			return null;
		}

		private List<T> GetDefaults<T>() where T : class, new()
		{
			return null;
		}

		internal T GetItem<T>() where T : class, new()
		{
			return null;
		}

		internal T GetItemOrDefault<T>() where T : class, new()
		{
			return null;
		}

		internal string JsonConfigurations(string type)
		{
			return "";
		}

		internal Dictionary<string, string> JsonConfigurations()
		{
			return null;
		}

		private List<object> VoodooTuneObjects(Type type, string json)
		{
			return null;
		}
	}
}
