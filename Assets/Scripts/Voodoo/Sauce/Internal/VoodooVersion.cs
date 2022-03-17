using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal
{
	[Serializable]
	public class VoodooVersion : ScriptableObject
	{
		public const string NAME = "VoodooVersion";

		public uint Major;

		public uint Minor;

		public uint Hotfix;

		public string Label;

		public int BuildNumber;

		public static VoodooVersion Load()
		{
			return null;
		}

		public new string ToString()
		{
			return "";
		}

		public void BumpMajor(string label = "")
		{
		}

		public void BumpMinor(string label = "")
		{
		}

		public void BumpHotfix(string label = "")
		{
		}

		public void BumpBuildNumber()
		{
		}

		public void ResetBuildNumber()
		{
		}

		public void DisableBuildNumber()
		{
		}

		public void UpdateLabel(string label = "")
		{
		}

		public void UpdateVersion(uint major, uint minor, uint hotfix, int buildNumber, string label = "")
		{
		}

		public void Save()
		{
		}
	}
}
