using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // certain variables for inspector
    public Animator transition; 
    public float transitionTime = 1f;

    // when first level then also transition
    public void LoadFirstLevel()
    {
        LoadNextLevel(1);
    }

    public void LoadNextLevel(int sceneIndex)
    {
        // Couroutine important for the syntax of LoadLevel
        StartCoroutine(LoadLevel(sceneIndex));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play this certain animation
        transition.SetTrigger("Start");
        // Wait
        yield return new WaitForSeconds(transitionTime);
        // Load the scene
        SceneManager.LoadScene(levelIndex);
    }
}
