using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    //public Animator transition;
    public float transitionTime = 1f;

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ER");
        if(other.CompareTag("Player")/* && !other.isTrigger*/)
        {
            playerStorage.initialValue = playerPosition;  
            StartCoroutine(LoadLevel());
        }

    }

    //Coroutine (weird syntax), so the animation has time to play out
    IEnumerator LoadLevel()
    {
        //Play animation
        //transition.SetTrigger("Start");

        //Whait
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
