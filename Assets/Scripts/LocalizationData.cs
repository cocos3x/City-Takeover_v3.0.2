using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LocalizationData : ScriptableObject
{
	[Serializable]
	public class LocEntry
	{
		public string ID;

		public string English;

		public string French;

		public string Japanese;

		public string ChineseSimplified;

		public string ChineseTraditional;

		public string Korean;

		public string Indonesian;

		public string German;

		public string Spanish;

		public string Italian;

		public string Portuguese;

		public string Russian;

		private Dictionary<SystemLanguage, string> translationMap;

		public void Clear()
		{
		}

		public string Get(SystemLanguage language)
		{
			return "";
		}

		public void PopulateMap()
		{
		}
	}

	[SerializeField]
	private SystemLanguage languageOverride;

	[SerializeField]
	private TMP_FontAsset defaultFont;

	[SerializeField]
	private TMP_FontAsset chineseSFont;

	[SerializeField]
	private TMP_FontAsset chineseTFont;

	[SerializeField]
	private TMP_FontAsset russianFont;

	[SerializeField]
	private TMP_FontAsset japaneseFont;

	[SerializeField]
	private TMP_FontAsset koreanFont;

	[SerializeField]
	private TMP_FontAsset liberationSans;

	[SerializeField]
	public List<LocEntry> locEntries;

	private Dictionary<string, LocEntry> _entriesMap;

	[SerializeField]
	private Dictionary<SystemLanguage, TMP_FontAsset> fontMapping;

	private Dictionary<string, LocEntry> entriesMap => null;

	private void _populateEntriesMap()
	{
	}

	public string Get(string id)
	{
		return "";
	}

	public bool HasLoc(string id)
	{
		return false;
	}

	public TMP_FontAsset GetFont()
	{
		return null;
	}

	public SystemLanguage CurrentLanguage()
	{
		//IL_0003: Expected I4, but got O
		return (SystemLanguage)null;
	}

	public void ParseFromJSONString(string jsonString)
	{
	}
}
