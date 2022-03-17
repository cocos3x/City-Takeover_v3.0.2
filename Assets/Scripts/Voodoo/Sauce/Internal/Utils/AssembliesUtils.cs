using System;
using System.Collections.Generic;
using System.Reflection;

namespace Voodoo.Sauce.Internal.Utils
{
	public static class AssembliesUtils
	{
		private sealed class _003C_003Ec__DisplayClass1_0<T> where T : class
		{
			public Type interfaceType;

			internal bool _003CInstantiateInterfaceImplementations_003Eb__1(Type type)
			{
				return false;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec__1<T> where T : class
		{
			public static readonly _003C_003Ec__1<T> _003C_003E9;

			public static Func<Assembly, IEnumerable<Type>> _003C_003E9__1_0;

			public static Func<Type, T> _003C_003E9__1_2;

			internal IEnumerable<Type> _003CInstantiateInterfaceImplementations_003Eb__1_0(Assembly assembly)
			{
				return null;
			}

			internal T _003CInstantiateInterfaceImplementations_003Eb__1_2(Type type)
			{
				return null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public Type toGetType;

			internal bool _003CGetTypes_003Eb__1(Type type)
			{
				return false;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<Assembly, IEnumerable<Type>> _003C_003E9__2_0;

			public static Comparison<Type> _003C_003E9__2_2;

			internal IEnumerable<Type> _003CGetTypes_003Eb__2_0(Assembly assembly)
			{
				return null;
			}

			internal int _003CGetTypes_003Eb__2_2(Type x, Type y)
			{
				return 0;
			}
		}

		private const string TAG = "AssembliesUtils";

		public static List<T> InstantiateInterfaceImplementations<T>() where T : class
		{
			return null;
		}

		public static List<Type> GetTypes(Type toGetType)
		{
			return null;
		}
	}
}
