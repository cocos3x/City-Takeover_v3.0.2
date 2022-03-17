using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	public class VoodooTuneNode
	{
		public enum Type
		{
			Cluster,
			ClusterVariant,
			AbTest
		}

		private readonly string _003CId_003Ek__BackingField;

		private readonly string _003CName_003Ek__BackingField;

		private readonly Type _003CNodeType_003Ek__BackingField;

		private readonly bool _003CIsDraft_003Ek__BackingField;

		public List<VoodooTuneNode> children;

		public string Id => "";

		public string Name => "";

		public Type NodeType => (Type)null;

		public bool IsDraft => false;

		public VoodooTuneNode(string id, string name, Type type, bool isDraft = false)
		{
		}
	}
}
