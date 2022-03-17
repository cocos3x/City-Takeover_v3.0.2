using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEngine;

namespace SimpleJSON
{
	public abstract class JSONNode
	{
		public struct Enumerator
		{
			private enum Type
			{
				None,
				Array,
				Object
			}

			private Type type;

			private Dictionary<string, JSONNode>.Enumerator m_Object;

			private List<JSONNode>.Enumerator m_Array;

			public bool IsValid => false;

			public KeyValuePair<string, JSONNode> Current => (KeyValuePair<string, JSONNode>)null;

			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		public struct ValueEnumerator
		{
			private Enumerator m_Enumerator;

			public JSONNode Current => null;

			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public ValueEnumerator GetEnumerator()
			{
				return (ValueEnumerator)null;
			}
		}

		public struct KeyEnumerator
		{
			private Enumerator m_Enumerator;

			public string Current => "";

			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public KeyEnumerator GetEnumerator()
			{
				return (KeyEnumerator)null;
			}
		}

		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			private JSONNode m_Node;

			private Enumerator m_Enumerator;

			public KeyValuePair<string, JSONNode> Current => (KeyValuePair<string, JSONNode>)null;

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

			internal LinqEnumerator(JSONNode aNode)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}

			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			public void Reset()
			{
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private sealed class _003Cget_Children_003Ed__41 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

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
			public _003Cget_Children_003Ed__41(int _003C_003E1__state)
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

		private sealed class _003Cget_DeepChildren_003Ed__43 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JSONNode _003C_003E4__this;

			private IEnumerator<JSONNode> _003C_003E7__wrap1;

			private IEnumerator<JSONNode> _003C_003E7__wrap2;

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
			public _003Cget_DeepChildren_003Ed__43(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
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

		public static bool forceASCII;

		public static bool longAsString;

		public static bool allowLineComments;

		private static StringBuilder m_EscapeBuilder;

		public static JSONContainerType VectorContainerType;

		public static JSONContainerType QuaternionContainerType;

		public static JSONContainerType RectContainerType;

		public abstract JSONNodeType Tag
		{
			get;
		}

		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual bool IsNumber => false;

		public virtual bool IsString => false;

		public virtual bool IsBoolean => false;

		public virtual bool IsNull => false;

		public virtual bool IsArray => false;

		public virtual bool IsObject => false;

		public virtual bool Inline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual IEnumerable<JSONNode> Children => null;

		public IEnumerable<JSONNode> DeepChildren => null;

		public IEnumerable<KeyValuePair<string, JSONNode>> Linq => null;

		public KeyEnumerator Keys => (KeyEnumerator)null;

		public ValueEnumerator Values => (ValueEnumerator)null;

		public virtual double AsDouble
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public virtual int AsInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual float AsFloat
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual long AsLong
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public virtual JSONArray AsArray => null;

		public virtual JSONObject AsObject => null;

		internal static StringBuilder EscapeBuilder => null;

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public virtual bool HasKey(string aKey)
		{
			return false;
		}

		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		public override string ToString()
		{
			return "";
		}

		public virtual string ToString(int aIndent)
		{
			return "";
		}

		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		public abstract Enumerator GetEnumerator();

		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		public static implicit operator string(JSONNode d)
		{
			return "";
		}

		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		public static implicit operator double(JSONNode d)
		{
			return 0.0;
		}

		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		public static implicit operator float(JSONNode d)
		{
			return 0f;
		}

		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		public static implicit operator int(JSONNode d)
		{
			return 0;
		}

		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		public static implicit operator long(JSONNode d)
		{
			return 0L;
		}

		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		public static implicit operator bool(JSONNode d)
		{
			return false;
		}

		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			return false;
		}

		public static bool operator !=(JSONNode a, object b)
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

		internal static string Escape(string aText)
		{
			return "";
		}

		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		public abstract void SerializeBinary(BinaryWriter aWriter);

		public void SaveToBinaryStream(Stream aData)
		{
		}

		public void SaveToCompressedStream(Stream aData)
		{
		}

		public void SaveToCompressedFile(string aFileName)
		{
		}

		public string SaveToCompressedBase64()
		{
			return "";
		}

		public void SaveToBinaryFile(string aFileName)
		{
		}

		public string SaveToBinaryBase64()
		{
			return "";
		}

		public static JSONNode DeserializeBinary(BinaryReader aReader)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		public static JSONNode LoadFromBinaryStream(Stream aData)
		{
			return null;
		}

		public static JSONNode LoadFromBinaryFile(string aFileName)
		{
			return null;
		}

		public static JSONNode LoadFromBinaryBase64(string aBase64)
		{
			return null;
		}

		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		public static implicit operator Vector2(JSONNode aNode)
		{
			return (Vector2)null;
		}

		public static implicit operator Vector3(JSONNode aNode)
		{
			return (Vector3)null;
		}

		public static implicit operator Vector4(JSONNode aNode)
		{
			return (Vector4)null;
		}

		public static implicit operator Quaternion(JSONNode aNode)
		{
			return (Quaternion)null;
		}

		public static implicit operator Rect(JSONNode aNode)
		{
			return (Rect)null;
		}

		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return (Vector2)null;
		}

		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return (Vector2)null;
		}

		public Vector2 ReadVector2()
		{
			return (Vector2)null;
		}

		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return (Vector3)null;
		}

		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return (Vector3)null;
		}

		public Vector3 ReadVector3()
		{
			return (Vector3)null;
		}

		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return (Vector4)null;
		}

		public Vector4 ReadVector4()
		{
			return (Vector4)null;
		}

		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return (Quaternion)null;
		}

		public Quaternion ReadQuaternion()
		{
			return (Quaternion)null;
		}

		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		public Rect ReadRect(Rect aDefault)
		{
			return (Rect)null;
		}

		public Rect ReadRect()
		{
			return (Rect)null;
		}

		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		public RectOffset ReadRectOffset()
		{
			return null;
		}

		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		public Matrix4x4 ReadMatrix()
		{
			return (Matrix4x4)null;
		}

		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}
	}
}
