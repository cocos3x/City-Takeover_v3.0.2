using System;
using System.Runtime.InteropServices;

public static class PlayerPrefsUtility
{
	public const string KEY_PREFIX = "ENC-";

	public const string VALUE_FLOAT_PREFIX = "0";

	public const string VALUE_INT_PREFIX = "1";

	public const string VALUE_STRING_PREFIX = "2";

	public static bool IsEncryptedKey(string key)
	{
		return false;
	}

	public static string DecryptKey(string encryptedKey)
	{
		return "";
	}

	public static void SetEncryptedFloat(string key, float value)
	{
	}

	public static void SetEncryptedInt(string key, int value)
	{
	}

	public static void SetEncryptedString(string key, string value)
	{
	}

	public static object GetEncryptedValue(string encryptedKey, string encryptedValue)
	{
		return null;
	}

	public static float GetEncryptedFloat(string key, float defaultValue = 0f)
	{
		return 0f;
	}

	public static int GetEncryptedInt(string key, int defaultValue = 0)
	{
		return 0;
	}

	public static string GetEncryptedString(string key, string defaultValue = "")
	{
		return "";
	}

	public static void SetBool(string key, bool value)
	{
	}

	public static bool GetBool(string key, bool defaultValue = false)
	{
		return false;
	}

	public static void SetEnum(string key, Enum value)
	{
	}

	public static T GetEnum<T>(string key, [Optional] T defaultValue) where T : struct
	{
		return (T)null;
	}

	public static object GetEnum(string key, Type enumType, object defaultValue)
	{
		return null;
	}

	public static void SetDateTime(string key, DateTime value)
	{
	}

	public static DateTime GetDateTime(string key, [Optional] DateTime defaultValue)
	{
		return (DateTime)null;
	}

	public static void SetTimeSpan(string key, TimeSpan value)
	{
	}

	public static TimeSpan GetTimeSpan(string key, [Optional] TimeSpan defaultValue)
	{
		return (TimeSpan)null;
	}
}
