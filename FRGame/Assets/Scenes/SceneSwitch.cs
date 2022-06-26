using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public int sceneBuildIndex;
    //public GameObject player;

    public void OnTriggerStay2D(Collider2D collision)
    {
        // if und else if für die einzelnen Szenen die switchen, nicht effektiv, aber ok i guess
        // wäre sinnvoll es durch nen switch in some sort zu ersetzen
        // ein Scene Switch für alles was Portale angeht?
        // what about transformations??
        if(collision.tag == "Player")
        {   
            Invoke("LoadScene", 2);
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

   /* IEnumerator Teleport(float a, float b, float c)
    {
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector3(a, b, c);
    }
   */
}
