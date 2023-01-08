using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;

	[SerializeField] private AudioSource musicSource, effectSource;

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void PlaySound(AudioClip clip)
	{
		effectSource.PlayOneShot(clip);
	}
}
