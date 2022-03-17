using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.Pattern.Random
{
	public class RandomizePseudo : MonoBehaviour
	{
		public static RandomizePseudo instance;

		public static string GetRandomPseudo(PseudoPool _list, int _minCharacterCount = 1, int _maxCharacterCount = -1)
		{
			return "";
		}

		public static Sprite GetRandomFlag(FlagPool _list)
		{
			return null;
		}

		public string GetRandomPseudo(List<PseudoPool> _lists, int _minCharacterCount = 1, int _maxCharacterCount = -1)
		{
			return "";
		}

		public static List<string> GetRandomPseudos(PseudoPool _list, int _numberRequired, bool _duplicateAllowed = false, int _minCharacterCount = 1, int _maxCharacterCount = -1)
		{
			return null;
		}

		public static List<Sprite> GetRandomFlags(FlagPool _list, int _numberRequired, bool _duplicateAllowed = false)
		{
			return null;
		}

		public List<string> GetRandomPseudos(List<PseudoPool> _lists, int _numberRequired, bool _duplicateAllowed = false, int _minCharacterCount = 1, int _maxCharacterCount = -1)
		{
			return null;
		}

		private void Awake()
		{
		}
	}
}
