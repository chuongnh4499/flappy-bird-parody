using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance { get => instance; }

    [Header("-------------- Audio Source --------------")]
    [SerializeField] protected AudioSource musicSource;
    [SerializeField] protected AudioSource SFXSource;

    [Header("-------------- Audio Clip --------------")]
    public AudioClip background;
    public AudioClip gun;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void ShootingSound()
    {
        SFXSource.PlayOneShot(gun);
    }

}
