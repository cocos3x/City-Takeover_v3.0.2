using DG.Tweening;
using System;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public AvatarController _003C_003E4__this;

		public Vector3 position;

		public float distance;

		public float speed;

		public Action callback;

		public TweenCallback _003C_003E9__1;

		internal void _003CMoveTo_003Eb__0()
		{
		}

		internal void _003CMoveTo_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public AvatarController _003C_003E4__this;

		public Action callback;

		public TweenCallback _003C_003E9__1;

		internal void _003CExpulseCharacterTo_003Eb__0()
		{
		}

		internal void _003CExpulseCharacterTo_003Eb__1()
		{
		}
	}

	[SerializeField]
	private Animator m_AvatarAnimator;

	[SerializeField]
	private ParticleSystem m_FightParticles;

	private Transform m_Transform;

	private bool m_IsFight;

	private bool m_Dance;

	public bool IsFight
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDance
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void MoveTo(Vector3 position, float speed, Action callback)
	{
	}

	public void ExpulseCharacterTo(Vector3 position, float speed, Action callback)
	{
	}

	public void TeleportToLevel(Vector3 position)
	{
	}

	public void LookAtCamera()
	{
	}
}
