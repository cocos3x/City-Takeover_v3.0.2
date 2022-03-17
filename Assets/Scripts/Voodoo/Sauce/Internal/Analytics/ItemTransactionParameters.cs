using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class ItemTransactionParameters
	{
		public string level;

		public ItemTransactionInfo item;

		public TransactionType transactionType;

		public float unitCost;

		public float nbUnits;

		public Enum currencyUsed;

		public float balance;

		public string iapLocalCurrency;

		public Enum placement;

		public string subPlacement;

		public string placementId;
	}
}
