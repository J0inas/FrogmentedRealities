using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public int sceneBuildIndex;

    void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {
            Invoke("LoadScene", 3);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CancelInvoke();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }

}
