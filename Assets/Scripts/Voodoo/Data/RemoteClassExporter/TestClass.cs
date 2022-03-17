using System;
using System.Collections.Generic;

namespace Voodoo.Data.RemoteClassExporter
{
	[Serializable]
	public class TestClass
	{
		public string myString;

		public int myInt;

		public int[] myIntArray;

		public double[] myDoubleArray;

		public long[] my64Array;

		public uint[] myu32Array;

		public decimal[] myDecArray;

		public List<float> myFloatList;

		public double myDouble;

		public MyEnum myEnum;

		public List<string> myStringList;

		public string[] myStringArray;

		public bool myBool;
	}
}
