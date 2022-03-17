namespace Voodoo.Sauce.Internal.Analytics
{
	internal abstract class BaseAnalyticsProviderWithLogger : IAnalyticsProvider
	{
		private bool _003CIsInitialized_003Ek__BackingField;

		public bool IsInitialized
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		internal abstract VoodooSauce.AnalyticsProvider GetProviderEnum();

		public abstract void Instantiate(string mediation);

		public abstract void Initialize(bool consent, bool isChinaBuild);

		internal virtual string GetUninitializedErrorMessage()
		{
			return "";
		}
	}
}
