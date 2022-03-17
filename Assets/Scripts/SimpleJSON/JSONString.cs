using System.IO;
using System.Text;

namespace SimpleJSON
{
	public class JSONString : JSONNode
	{
		private string m_Data;

		public override JSONNodeType Tag => (JSONNodeType)null;

		public override bool IsString => false;

		public override string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public override Enumerator GetEnumerator()
		{
			return (Enumerator)null;
		}

		public JSONString(string aData)
		{
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
}
