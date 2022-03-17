using System;
using System.Collections.Generic;
using System.Reflection;

namespace Voodoo.Utils
{
	public class TypeUtility
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<Assembly> _003C_003E9__8_0;

			public static Predicate<Assembly> _003C_003E9__11_0;

			public static Predicate<Assembly> _003C_003E9__14_0;

			public static Predicate<Assembly> _003C_003E9__15_0;

			public static Predicate<Assembly> _003C_003E9__16_0;

			public static Predicate<Assembly> _003C_003E9__17_0;

			public static Predicate<Assembly> _003C_003E9__18_0;

			public static Predicate<Assembly> _003C_003E9__19_0;

			public static Predicate<Assembly> _003C_003E9__20_0;

			public static Predicate<Assembly> _003C_003E9__21_0;

			public static Predicate<Assembly> _003C_003E9__22_0;

			public static Predicate<Type> _003C_003E9__22_1;

			public static Predicate<Assembly> _003C_003E9__23_0;

			public static Predicate<Type> _003C_003E9__23_1;

			public static Predicate<Assembly> _003C_003E9__26_0;

			public static Predicate<Assembly> _003C_003E9__27_0;

			public static Predicate<Assembly> _003C_003E9__28_0;

			public static Predicate<Assembly> _003C_003E9__29_0;

			internal bool _003CGetTypes_003Eb__8_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetExportedTypes_003Eb__11_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetPluginTypes_003Eb__14_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetEditorPluginTypes_003Eb__15_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetMainTypes_003Eb__16_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetEditorTypes_003Eb__17_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetPluginExportedTypes_003Eb__18_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetEditorPluginExportedTypes_003Eb__19_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetMainExportedTypes_003Eb__20_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetEditorExportedTypes_003Eb__21_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetAllTypes_003Eb__22_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetAllTypes_003Eb__22_1(Type type)
			{
				return false;
			}

			internal bool _003CGetAllExportedTypes_003Eb__23_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetAllExportedTypes_003Eb__23_1(Type type)
			{
				return false;
			}

			internal bool _003CGetMainpassTypes_003Eb__26_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetFirstspassTypes_003Eb__27_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetMainpassExportedTypes_003Eb__28_0(Assembly assembly)
			{
				return false;
			}

			internal bool _003CGetFirstspassExportedTypes_003Eb__29_0(Assembly assembly)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public string fullname;

			internal bool _003CGetType_003Eb__0(Type curType)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public string fullname;

			internal bool _003CGetExportedType_003Eb__0(Type curType)
			{
				return false;
			}
		}

		private const string assemblyCSharp = "Assembly-CSharp";

		private const string assemblyCSharpFirstPass = "Assembly-CSharp-firstpass";

		private const string assemblyCSharpEditor = "Assembly-CSharp-Editor";

		private const string assemblyCSharpEditorFirstPass = "Assembly-CSharp-Editor-firstpass";

		private static Assembly[] assemblies;

		private static Assembly[] Assemblies
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<Type> GetTypes(Predicate<Type> typeCondition)
		{
			return null;
		}

		public static List<Type> GetTypes(Predicate<Assembly> assemblyCondition, Predicate<Type> typeCondition)
		{
			return null;
		}

		public static List<Type> GetTypes(Predicate<Assembly> assemblyCondition)
		{
			return null;
		}

		public static List<Type> GetExportedTypes(Predicate<Type> typeCondition)
		{
			return null;
		}

		public static List<Type> GetExportedTypes(Predicate<Assembly> assemblyCondition, Predicate<Type> typeCondition)
		{
			return null;
		}

		public static List<Type> GetExportedTypes(Predicate<Assembly> assemblyCondition)
		{
			return null;
		}

		public static List<Type> GetPluginTypes()
		{
			return null;
		}

		public static List<Type> GetEditorPluginTypes()
		{
			return null;
		}

		public static List<Type> GetMainTypes()
		{
			return null;
		}

		public static List<Type> GetEditorTypes()
		{
			return null;
		}

		public static List<Type> GetPluginExportedTypes()
		{
			return null;
		}

		public static List<Type> GetEditorPluginExportedTypes()
		{
			return null;
		}

		public static List<Type> GetMainExportedTypes()
		{
			return null;
		}

		public static List<Type> GetEditorExportedTypes()
		{
			return null;
		}

		public static List<Type> GetAllTypes()
		{
			return null;
		}

		public static List<Type> GetAllExportedTypes()
		{
			return null;
		}

		public static Type GetType(string fullname)
		{
			return null;
		}

		public static Type GetExportedType(string fullname)
		{
			return null;
		}

		public static List<Type> GetMainpassTypes()
		{
			return null;
		}

		public static List<Type> GetFirstspassTypes()
		{
			return null;
		}

		public static List<Type> GetMainpassExportedTypes()
		{
			return null;
		}

		public static List<Type> GetFirstspassExportedTypes()
		{
			return null;
		}
	}
}
