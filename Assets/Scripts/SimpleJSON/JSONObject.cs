using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SimpleJSON
{
	public class JSONObject : JSONNode
	{
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public JSONNode aNode;

			internal bool _003CRemove_003Eb__0(KeyValuePair<string, JSONNode> k)
			{
				return false;
			}
		}

		private sealed class _003Cget_Children_003Ed__25 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JSONObject _003C_003E4__this;

			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_Children_003Ed__25(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private Dictionary<string, JSONNode> m_Dict;

		private bool inline;

		public override bool Inline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override JSONNodeType Tag => (JSONNodeType)null;

		public override bool IsObject => false;

		public override JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int Count => 0;

		public override IEnumerable<JSONNode> Children => null;

		public override Enumerator GetEnumerator()
		{
			return (Enumerator)null;
		}

		public override void Add(string aKey, JSONNode aItem)
		{
		}

		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public override bool HasKey(string aKey)
		{
			return false;
		}

		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
}
