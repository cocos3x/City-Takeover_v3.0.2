using DG.Tweening;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static TweenCallback _003C_003E9__59_0;

		internal void _003CStopSong_003Eb__59_0()
		{
		}
	}

	public static AudioManager Instance;

	[SerializeField]
	private AudioSource musicSource;

	[SerializeField]
	private AudioSource sfxSource;

	[SerializeField]
	private AudioSource sfxSourcePitch;

	[SerializeField]
	private AudioClip buttonClip;

	[SerializeField]
	private AudioClip starClip;

	[SerializeField]
	private AudioClip buildingConnect;

	[SerializeField]
	private AudioClip buildingClick;

	[SerializeField]
	private AudioClip buildingCut;

	[SerializeField]
	private AudioClip buildingGained;

	[SerializeField]
	private AudioClip buildingLost;

	[SerializeField]
	private AudioClip coinsClip;

	[SerializeField]
	private AudioClip coinClip;

	[SerializeField]
	private AudioClip purchaseClip;

	[SerializeField]
	private AudioClip onAvatarAttack;

	[SerializeField]
	private AudioClip onAvatarDefend;

	[SerializeField]
	private AudioClip onAvatarDie;

	[SerializeField]
	private AudioClip levelComplete;

	[SerializeField]
	private AudioClip handClap;

	[SerializeField]
	private AudioClip errorClip;

	[SerializeField]
	private AudioClip lossClip;

	[SerializeField]
	private AudioClip powerUpClip;

	[SerializeField]
	private AudioClip freezeClip;

	[SerializeField]
	private AudioClip meteorClip;

	[SerializeField]
	private AudioClip buildingGrowClip;

	[SerializeField]
	private AudioClip shieldClip;

	[SerializeField]
	private AudioClip[] songs;

	[SerializeField]
	private AudioClip bossSong;

	private void Awake()
	{
	}

	public static void SetSFXVolume(float v)
	{
	}

	public static void SetMusicVolume(float v)
	{
	}

	public static float GetSFXVolume()
	{
		return 0f;
	}

	public static float GetMusicVolume()
	{
		return 0f;
	}

	private void _PlayOneShotRandomPitch(AudioClip clip, float minPitch, float maxPitch)
	{
	}

	private void _PlayOneShot(AudioClip clip)
	{
	}

	public static void PlayButtonClick()
	{
	}

	public static void PlayError()
	{
	}

	public static void PlayStar()
	{
	}

	public static void PlayCoins()
	{
	}

	public static void PlayCoin()
	{
	}

	public static void PlayPurchase()
	{
	}

	public static void PlayLevelComplete()
	{
	}

	public static void PlayHandClap()
	{
	}

	public static void PlayBuildingConnect()
	{
	}

	public static void PlayBuildingCut()
	{
	}

	public static void PlayBuildingClick()
	{
	}

	public static void PlayBuildingGained()
	{
	}

	public static void PlayBuildingLost()
	{
	}

	public static void PlayOnAvatarAttack()
	{
	}

	public static void PlayOnAvatarDefend()
	{
	}

	public static void PlayOnAvatarDie(float pitch = 1f)
	{
	}

	public static void PlayLoss()
	{
	}

	public static void PlayPowerUp()
	{
	}

	public static void PlayFreeze()
	{
	}

	public static void PlayMeteor()
	{
	}

	public static void PlayShield()
	{
	}

	public static void PlayBuildingGrow()
	{
	}

	public static void PlayNewSong()
	{
	}

	public static void PlayBossSong()
	{
	}

	public static void StopSong(bool fade = true)
	{
	}
}
