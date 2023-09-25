using UnityEngine;

public class MainMenuManagement : ProjectBehaviour
{
    [SerializeField] protected GameObject title;
    [SerializeField] protected GameObject btnPlay;

    public void Start()
    {
        DisplayUI(true);
    }

    public void PlayGame()
    {
        MainMenuScenceTrans.Instance.LoadNextScene();
        DisplayUI(false);
    }

    protected void DisplayUI(bool value)
    {
        title.SetActive(value);
        btnPlay.SetActive(value);
    }
}
