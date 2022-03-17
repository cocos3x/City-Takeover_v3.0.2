using System;
using UnityEngine;

namespace Voodoo.Sauce.Core
{
	[Serializable]
	public class ProductDescriptor
	{
		[SerializeField]
		private string _productId;

		[SerializeField]
		private VoodooSettingsProductType _type;

		[SerializeField]
		private float _priceInUSD;

		public string ProductId => "";

		public string OriginalProductId => "";

		public VoodooSettingsProductType Type => (VoodooSettingsProductType)null;

		public float PriceInUSD => 0f;

		public ProductDescriptor(string productId, VoodooSettingsProductType type, float priceInUsd)
		{
		}

		public bool IsValidAndroidProductId()
		{
			return false;
		}

		public string GetAndroidProductId()
		{
			return "";
		}

		public static string ParseAndroidProductId(string productIdString)
		{
			return "";
		}
	}
}
