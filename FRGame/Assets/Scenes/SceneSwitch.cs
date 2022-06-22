using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public int sceneBuildIndex;
    public int currentScene;
    public int portal;

    void OnTriggerStay2D(Collider2D collision)
    {
        // if und else if für die einzelnen Szenen die switchen, nicht effektiv, aber ok i guess
        // wäre sinnvoll es durch nen switch in some sort zu ersetzen
        // ein Scene Switch für alles was Portale angeht?
        // what about transformations??
        if(collision.tag == "Player")
        {   
            if(portal == 0 && currentScene == 1)
            {
                Invoke("LoadScene", 3); // hier muss das rein mit WOHIN man sich warpt
            }
            else if (portal == 1 && currentScene == 1)
            {
                Invoke("LoadScene", 3);
            }
            else if (portal == 2 && currentScene == 1)
            {
                Invoke("LoadScene", 3);
            }
            // and so on
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
