using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Scripts
{
	public static class Focus
	{
		public struct Event
		{
			public bool hasFocus;

			public DateTime time;

			public Event(bool hasFocus, DateTime time)
			{
			}
		}

		public static List<Event> Events;
	}
}
