
using UnityEngine;

public class MainMenuScenceTrans : SceneTransitions
{
    private static MainMenuScenceTrans instance;
    public static MainMenuScenceTrans Instance { get => instance; }

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.LogError("Only one MainMenuScenceTrans allow to exist");
        instance = this;        
    }

}
