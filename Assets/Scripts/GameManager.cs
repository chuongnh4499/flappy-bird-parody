
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get => instance; }

    public Player player;
    public TextMeshPro scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    private void Awake()
    {
        if (GameManager.instance != null) {
            Debug.LogError("Only 1 GameManager allow to exist");
        }

        instance = this;
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        PipesGreen[] pipesGreen = FindObjectsOfType<PipesGreen>();

        foreach (PipesGreen pipe in pipesGreen)
        {
            Destroy(pipe.gameObject);
        }

    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
