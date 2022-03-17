using System;

namespace Voodoo.Sauce.IAP
{
	[Serializable]
	public class JsonData
	{
		public bool validated;

		public int storeStatusCode;

		public bool restored;
	}
}
