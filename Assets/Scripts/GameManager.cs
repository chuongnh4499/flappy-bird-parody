using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : ProjectBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get => instance; }
    private string statusGame = Status.DEFAULT;
    private int score;
    [SerializeField] protected TextMeshProUGUI scoreText;
    [SerializeField] protected GameObject gameOver;
    [SerializeField] protected GameObject playAgainButton;
    [SerializeField] protected GameObject quitButton;
    [SerializeField] private bool disablePause = false;

    protected override void Awake()
    {
        base.Awake();
        if (GameManager.instance != null)
        {
            Debug.LogError("Only 1 GameManager allow to exist");
        }
        instance = this;
    }

    protected override void LoadComponents()
    {
        Play();
        LoadAppFrameRate();
    }

    public void Play()
    {
        SetStatusGame(Status.PLAY);
        AudioManager.Instance.PlayBackgroundSound();
        ResetScore();
        DisplaySubMenu(false);

        Time.timeScale = 1f;
        Player.Instance.enabled = true;

        // Destroy object was spawned
        ClearObjSpawned();
    }

    protected void LoadAppFrameRate()
    {
        Application.targetFrameRate = 60;
    }

    protected void Pause()
    {
        // Disable pause for testing
        if (disablePause) return;

        SetStatusGame(Status.PAUSE);
        Time.timeScale = 0f;
        Player.Instance.enabled = false;

        DisplaySubMenu(true);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        AudioManager.Instance.PlayGameOverSound();
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        AudioManager.Instance.IncreaseScoreSound();
    }

    protected void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    protected void ClearObjSpawned()
    {
        PipesSpawner.Instance.DestroyAllObj();
        BulletSpawner.Instance.DestroyAllObj();
    }

    public void QuitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    protected void DisplaySubMenu(bool status)
    {
        gameOver.SetActive(status);
        playAgainButton.SetActive(status);
        quitButton.SetActive(status);
    }


    // Getter & Setter
    public string GetStatusGame()
    {
        return statusGame;
    }
    public void SetStatusGame(string value)
    {
        statusGame = value;
    }

}
