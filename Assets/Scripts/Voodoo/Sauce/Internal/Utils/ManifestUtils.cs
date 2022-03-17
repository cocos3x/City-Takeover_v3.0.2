using System.Collections.Generic;
using System.Xml;

namespace Voodoo.Sauce.Internal.Utils
{
	public static class ManifestUtils
	{
		private const string DESTINATION_APPLICATION_MANIFEST_PATH = "Assets/Plugins/Android/AndroidManifest.xml";

		public static bool Add(string manifestSourcePath)
		{
			return false;
		}

		public static bool Replace(Dictionary<string, string> keysValues)
		{
			return false;
		}

		private static XmlDocument Load(string manifestPath)
		{
			return null;
		}

		private static void AddPermission(XmlDocument document, XmlNode sourceNode)
		{
		}

		private static void AddChildNode(XmlDocument document, XmlNode parent, XmlNode node)
		{
		}

		private static XmlNode FindChildNode(XmlNode parent, XmlNode child)
		{
			return null;
		}

		private static bool FindElementWithAndroidName(XmlNode parent, XmlNode child)
		{
			return false;
		}

		private static string GetAndroidElementName(XmlNode node, string namespaceOfPrefix)
		{
			return "";
		}

		private static void save(string manifestPath, XmlDocument document)
		{
		}
	}
}
