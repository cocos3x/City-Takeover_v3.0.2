using System.Collections.Generic;
using UnityEngine;

public class EmojiData : ScriptableObject
{
	[SerializeField]
	private List<Sprite> _happyFaces;

	[SerializeField]
	private List<Sprite> _sadFaces;

	public Sprite GetRandomHappyFace()
	{
		return null;
	}

	public Sprite GetRandomSadFace()
	{
		return null;
	}
}
