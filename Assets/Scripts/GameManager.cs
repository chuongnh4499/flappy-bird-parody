
using TMPro;
using UnityEngine;

public class GameManager : ProjectBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get => instance; }
    public string statusMatch = Constants.PAUSE;
    [SerializeField] protected Player player;
    [SerializeField] protected TextMeshPro scoreText;
    [SerializeField] protected GameObject playButton;
    [SerializeField] protected GameObject gameOver;
    [SerializeField] protected int score;
 
    protected override void Awake()
    {
        if (GameManager.instance != null) {
            Debug.LogError("Only 1 GameManager allow to exist");
        }

        instance = this;
        Application.targetFrameRate = 60;
        Pause();
    }

    protected void Play()
    {
        statusMatch = Constants.PLAY;
        AudioManager.Instance.PlayBackgroundSound();
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        // Destroy object was spawned
        PipesSpawner.Instance.DestroyAllObj();
        BulletSpawner.Instance.DestroyAllObj();
    }

    protected void Pause()
    {
        statusMatch = Constants.PAUSE;
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        statusMatch = Constants.GAME_OVER;
        gameOver.SetActive(true);
        playButton.SetActive(true);
        AudioManager.Instance.PlayGameOverSound();
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        AudioManager.Instance.IncreaseScoreSound();
    }

}
