using UnityEngine;

public class BaseScreenUi : MonoBehaviour
{
	public delegate void d_OnOpenHandle();

	public delegate void d_OnCloseHandle();

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public BaseScreenUi _003C_003E4__this;

		public bool show;
	}

	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public float to;

		public _003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals1;

		internal void _003CShow_003Eb__0()
		{
		}
	}

	private bool _003CisShown_003Ek__BackingField;

	[SerializeField]
	private CanvasGroup canvasGroup;

	protected GameUi gameUi;

	public d_OnOpenHandle OnOpenHandle;

	public d_OnCloseHandle OnCloseHandle;

	public bool isShown
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	protected virtual void OnDisable()
	{
	}

	public void Show(bool show, bool fade = false, float fadingDuration = 0.2f)
	{
	}

	public virtual void OnOpen()
	{
	}

	public virtual void OnClose()
	{
	}
}
