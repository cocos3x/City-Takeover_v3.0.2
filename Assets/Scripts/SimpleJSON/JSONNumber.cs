using System.IO;
using System.Text;

namespace SimpleJSON
{
	public class JSONNumber : JSONNode
	{
		private double m_Data;

		public override JSONNodeType Tag => (JSONNodeType)null;

		public override bool IsNumber => false;

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

		public override double AsDouble
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public override long AsLong
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override Enumerator GetEnumerator()
		{
			return (Enumerator)null;
		}

		public JSONNumber(double aData)
		{
		}

		public JSONNumber(string aData)
		{
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		private static bool IsNumeric(object value)
		{
			return false;
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
