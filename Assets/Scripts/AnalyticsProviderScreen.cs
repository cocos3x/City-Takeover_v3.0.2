using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.Analytics;

public class AnalyticsProviderScreen : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public int localIndex;

		public AnalyticsProviderScreen _003C_003E4__this;

		internal void _003CStart_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public AnalyticsProviderScreen _003C_003E4__this;

		public DebugAnalyticsLog log;
	}

	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public int index;

		public _003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals1;

		internal void _003CReceiveAnalyticsEvent_003Eb__0()
		{
		}
	}

	private const string TAG = "AnalyticsProviderScreen";

	private const string DEFAULT_TEST_EVENT_NAME = "test_analytics_integration";

	private const string DEFAULT_TEST_EVENT_NAME_SEPARATOR = "||";

	private static readonly ConcurrentQueue<Action> _runOnMainThread;

	[SerializeField]
	private GameObject _analyticsProviderLineItemPrefab;

	[SerializeField]
	private VerticalLayoutGroup _container;

	private readonly List<AnalyticsProviderLineItems> _providerUiItemList;

	private readonly List<VoodooSauce.AnalyticsProvider> _providerEnumList;

	private void Update()
	{
	}

	private void Start()
	{
	}

	private void ListenToAnalyticsLogger()
	{
	}

	private string GetDescTextFromState(DebugAnalyticsLog log)
	{
		return "";
	}

	private void ReceiveAnalyticsEvent(DebugAnalyticsLog log, bool isUpdateFromExisting)
	{
	}

	private string GetDescMessageOnSending(BaseAnalyticsProviderWithLogger providerWithLogger)
	{
		return "";
	}

	private void ProviderTestClicked(int index)
	{
	}

	private List<VoodooSauce.AnalyticsProvider> GetProviderList(int index)
	{
		return null;
	}

	private string GetTestEventName(int index, [Optional] string providerName)
	{
		return "";
	}

	private static VoodooSauce.AnalyticsProvider? GetProviderEnumFromString(string name)
	{
		return null;
	}

	private static List<VoodooSauce.AnalyticsProvider> GetAllProviderEnum()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
