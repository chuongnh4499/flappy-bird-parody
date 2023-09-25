using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : ProjectBehaviour
{
   [SerializeField] protected float transitionTime = 1f;
   [SerializeField] protected Animator transition;

   protected override void Awake()
   {
      transition.gameObject.SetActive(false);
   }

   public virtual void LoadNextScene()
   {
      StartCoroutine(LoadSceneLevel(SceneManager.GetActiveScene().buildIndex + 1));
   }

   public virtual void LoadMainMenuScene()
   {
      StartCoroutine(LoadSceneLevel(0));
   }

   IEnumerator LoadSceneLevel(int levelIndex)
   {
      transition.gameObject.SetActive(true);
      transition.SetTrigger("End");

      yield return new WaitForSeconds(transitionTime);

      SceneManager.LoadSceneAsync(levelIndex);

      transition.SetTrigger("Start");
   }
}
