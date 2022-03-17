namespace Voodoo.Sauce.Internal.Analytics
{
	internal interface IAnalyticsProvider
	{
		void Instantiate(string mediation);

		void Initialize(bool consent, bool isChinaBuild);
	}
}
