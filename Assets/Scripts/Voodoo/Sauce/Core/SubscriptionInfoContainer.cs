using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Voodoo.Sauce.Core
{
	[Serializable]
	public class SubscriptionInfoContainer : ISerializationCallbackReceiver
	{
		public static readonly string SubscriptionFilePath;

		[SerializeField]
		private long _lPurchaseDate;

		[SerializeField]
		private long _lIntroductoryPricePeriod;

		[SerializeField]
		private long _lExpireDate;

		[SerializeField]
		private long _lCancelDate;

		[SerializeField]
		private long _lFreeTrialPeriod;

		[SerializeField]
		private long _lSubscriptionPeriod;

		public string productId;

		public SubscriptionResult isSubscribed;

		public SubscriptionResult isExpired;

		public SubscriptionResult isCancelled;

		public SubscriptionResult isFreeTrial;

		public SubscriptionResult isAutoRenewing;

		public SubscriptionResult isIntroductoryPricePeriod;

		public string introductoryPrice;

		public long introductoryPricePeriodCycles;

		public string freeTrialPeriodString;

		public string skuDetails;

		public string subscriptionInfoJson;

		[NonSerialized]
		public DateTime cancelDate;

		[NonSerialized]
		public DateTime expireDate;

		[NonSerialized]
		public TimeSpan freeTrialPeriod;

		[NonSerialized]
		public TimeSpan introductoryPricePeriod;

		[NonSerialized]
		public DateTime purchaseDate;

		[NonSerialized]
		public TimeSpan subscriptionPeriod;

		public SubscriptionInfoContainer()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public static void ClearSavedSubscriptionInfo()
		{
		}

		public SubscriptionInfoContainer(SubscriptionInfo data)
		{
		}

		public static void SaveSubscriptionInfo(SubscriptionInfoContainer data)
		{
		}

		public static Dictionary<string, SubscriptionInfoContainer> LoadSubscriptionInfo()
		{
			return null;
		}
	}
}
