using System;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo
{
	internal class CrossPromoEvents
	{
		internal static event Action<string> OnInitComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<AssetModel> OnClick
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<AssetModel> OnShown
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<Exception> OnError
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static void TriggerInitComplete(string format)
		{
		}

		internal static void TriggerClickEvent(AssetModel asset)
		{
		}

		internal static void TriggerShownEvent(AssetModel asset)
		{
		}

		internal static void TriggerErrorEvent(Exception message)
		{
		}
	}
}
