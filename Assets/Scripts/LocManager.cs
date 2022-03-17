using System;
using TMPro;
using UnityEngine;

public class LocManager
{
	private static LocalizationData _locData;

	private static LocalizationData locData => null;

	public static string Get(string id)
	{
		return "";
	}

	public static bool HasLoc(string id)
	{
		return false;
	}

	public static void UpdateTMP(TMP_Text text)
	{
	}

	public static SystemLanguage CurrentLanguage()
	{
		//IL_0003: Expected I4, but got O
		return (SystemLanguage)null;
	}

	public static void _SetLocData(LocalizationData data)
	{
	}

	public static string ParseTimespan(TimeSpan t)
	{
		return "";
	}
}
