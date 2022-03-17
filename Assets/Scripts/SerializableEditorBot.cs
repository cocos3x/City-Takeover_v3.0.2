using System;
using System.Collections.Generic;

[Serializable]
public class SerializableEditorBot
{
	public int team;

	public float minDecisionMakingTime;

	public float maxDecisionMakingTime;

	public bool allowTakeover;

	public List<SerializableEditorBotAction> botActions;
}
