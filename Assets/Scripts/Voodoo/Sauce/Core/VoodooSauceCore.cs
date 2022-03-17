using System;
using System.Collections.Generic;
using System.Reflection;
using Voodoo.Sauce.Internal;
using Voodoo.Sauce.Internal.DebugScreen;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Core
{
	internal static class VoodooSauceCore
	{
		[Serializable]
		private sealed class _003C_003Ec__3<TParentClass> where TParentClass : class
		{
			public static readonly _003C_003Ec__3<TParentClass> _003C_003E9;

			public static Func<Assembly, IEnumerable<Type>> _003C_003E9__3_0;

			internal IEnumerable<Type> _003CInstantiateChildClass_003Eb__3_0(Assembly assembly)
			{
				return null;
			}
		}

		private const string TAG = "VoodooSauceCore";

		private static readonly IAPCore _iap;

		private static TModule InstantiateModule<TModule>() where TModule : class, IModule, new()
		{
			return null;
		}

		private static TModule GetModuleInstance<TModule>(TModule moduleInstance, bool logWarning) where TModule : class, IModule, new()
		{
			return null;
		}

		private static TParentClass InstantiateChildClass<TParentClass>() where TParentClass : class
		{
			return null;
		}

		static VoodooSauceCore()
		{
		}

		public static void ShowGeneralInfo(DebugGeneralInfoScreen screen, VoodooSettings settings)
		{
		}

		public static List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}

		internal static IAPCore GetInAppPurchase(bool logWarning = false)
		{
			return null;
		}
	}
}
