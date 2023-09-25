using UnityEngine;

public class AudioManager : ProjectBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance { get => instance; }

    [Header("-------------- Audio Source --------------")]
    [SerializeField] protected AudioSource musicSource;
    [SerializeField] protected AudioSource SFXSource;

    [Header("-------------- Audio Clip --------------")]
    public AudioClip background;
    public AudioClip gun;
    public AudioClip point;
    public AudioClip gameOver;

    protected override void Awake()
    {
        if (instance != null) Debug.LogError("Only one AudioManager allow to exist");
        instance = this;
    }

    void Start()
    {
        SFXSource.volume = 0.5f;
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayBackgroundSound()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void StopBackgroundSound()
    {
        musicSource.Stop();
    }

    public void ShootingSound()
    {
        SFXSource.PlayOneShot(gun);
    }

    public void IncreaseScoreSound()
    {
        SFXSource.volume = 1f;
        SFXSource.PlayOneShot(point);
    }

    public void PlayGameOverSound()
    {
        musicSource.clip = gameOver;
        musicSource.Play();
    }

}
