using UnityEngine;

public class GamePlayScenceTrans : SceneTransitions
{
   private static GamePlayScenceTrans instance;
   public static GamePlayScenceTrans Instance { get => instance; }

   protected override void Awake()
   {
      base.Awake();
      if (instance != null) Debug.LogError("Only one GamePlayScenceTrans allow to exist");
      instance = this;      
   }
}
