using System;
using System.Collections.Generic;
using System.Reflection;

namespace Voodoo.Utils
{
	public static class TypeExtension
	{
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public Type type;

			internal bool _003CGetAllDerivedTypes_003Eb__0(Type curType)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public Type interfaceType;

			internal bool _003CGetTypesFromInterface_003Eb__1(Type type)
			{
				return false;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<Assembly> _003C_003E9__2_0;

			internal bool _003CGetTypesFromInterface_003Eb__2_0(Assembly assembly)
			{
				return false;
			}
		}

		public static Type GetIEnumerableElementType(this Type seqType)
		{
			return null;
		}

		public static List<Type> GetAllDerivedTypes(this Type type)
		{
			return null;
		}

		public static List<Type> GetTypesFromInterface(this Type interfaceType)
		{
			return null;
		}

		public static string FriendlyName(this Type type)
		{
			return "";
		}

		public static string GenericName(this Type type)
		{
			return "";
		}

		private static string SimplifyName(this Type type, char startingChar, char endingChar, bool useFullName)
		{
			return "";
		}

		private static Type FindIEnumerable(this Type seqType)
		{
			return null;
		}
	}
}
