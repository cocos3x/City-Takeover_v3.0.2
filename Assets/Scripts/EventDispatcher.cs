using UnityEngine;

public class EventDispatcher : MonoBehaviour
{
	public delegate void EventHandler(GameObject e);

	public delegate void EventHandlerCollision(GameObject e, Collision c);

	public delegate void EventHandlerTrigger(GameObject e, Collider c);

	public event EventHandler onMouseDown
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EventHandlerCollision onCollisionEnter
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EventHandlerTrigger onTriggerEnter
	{
		add
		{
		}
		remove
		{
		}
	}

	private void OnMouseDown()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
