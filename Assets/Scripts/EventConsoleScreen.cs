using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.Analytics;

public class EventConsoleScreen : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string filter;

		internal bool _003CFillEventLogToScreen_003Eb__0(DebugAnalyticsLog x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public DebugAnalyticsLog log;

		public EventConsoleScreen _003C_003E4__this;

		public int addedLogIndex;

		internal bool _003CHandleNewEventEmitted_003Eb__1(DebugAnalyticsLog x)
		{
			return false;
		}

		internal void _003CHandleNewEventEmitted_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public EventConsoleScreen _003C_003E4__this;

		public int addedItemIndex;

		internal void _003CFillLogToLineItems_003Eb__0()
		{
		}
	}

	private const string TAG = "EventConsoleScreen";

	private const string DEFAULT_WRAPPER_NAME_FILTER = "VoodooAnalytics";

	private static readonly ConcurrentQueue<Action> _runOnMainThread;

	private List<DebugAnalyticsLog> _analyticsLogs;

	private bool _isDebugEnabled;

	[SerializeField]
	private GameObject _eventLogItemPrefab;

	[SerializeField]
	private VerticalLayoutGroup _container;

	[SerializeField]
	private InputField _filterField;

	[SerializeField]
	private GameObject _eventDescriptionContainer;

	[SerializeField]
	private Text _eventDescriptionText;

	[SerializeField]
	private Text _eventDescriptionHeaderEventName;

	[SerializeField]
	private Text _eventDescriptionHeaderEventTime;

	[SerializeField]
	private Button _eventDescriptionHeaderCloseDescButton;

	[SerializeField]
	private Button _eventDescriptionHeaderCopyDescButton;

	[SerializeField]
	private GameObject _logPanel;

	[SerializeField]
	private GameObject _pauseButton;

	[SerializeField]
	private Image _debugButtonImage;

	[SerializeField]
	private GameObject _parentDebugMenuScreen;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void EnableAnalyticsLoggingAndDebugging(bool isEnabled)
	{
	}

	private void FillEventLogToScreen(string filter = "")
	{
	}

	private void HandleNewEventEmitted(DebugAnalyticsLog log, bool isUpdateFromExisting)
	{
	}

	private void FillLogToLineItems(int addedItemIndex)
	{
	}

	private void FilterChanged(string text)
	{
	}

	private void ShowDescription(int index)
	{
	}

	private string ReformatParamJsonString(string param)
	{
		return "";
	}

	private void HideDescription()
	{
	}

	private void CopyButtonClicked()
	{
	}

	public void FlushLog()
	{
	}

	public void PlayPressed()
	{
	}

	public void PausePressed()
	{
	}

	public void ClosePressed()
	{
	}

	public void DebugButtonClicked(bool forceDisable = false)
	{
	}
}
