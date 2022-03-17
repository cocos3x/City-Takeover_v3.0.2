using mixpanel;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class CustomMixpanelEvent : MixpanelEvent
	{
		public Value Props;

		protected override void PerformTrackEvent()
		{
		}

		public CustomMixpanelEvent(string eventName, Value props)
		{
		}
	}
}
