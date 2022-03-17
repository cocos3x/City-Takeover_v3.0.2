using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.IntegrationCheck
{
	public class IntegrationCheckMessage
	{
		public enum Type
		{
			WARNING,
			ERROR
		}

		public readonly Type type;

		public readonly bool isBackToSettingsBtnDisplayed;

		private readonly string _description;

		private readonly string[] parameters;

		public string Description => "";

		public IntegrationCheckMessage(Type type, string description, [Optional] string[] parameters, bool isBackToSettingsBtnDisplayed = false)
		{
		}
	}
}
