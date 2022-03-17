using UnityEngine;

public class CustomLabelAndValueAttribute : PropertyAttribute
{
	public readonly string Name;

	public readonly bool Separator;

	public CustomLabelAndValueAttribute(string name, bool separator = false)
	{
	}
}
