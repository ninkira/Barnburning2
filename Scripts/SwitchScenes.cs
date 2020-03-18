using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{

   public void LoadScence()
    {

        SceneManager.LoadScene(1);
    }

    public void LoadLivingRoom()
    {

        SceneManager.LoadScene(2);
    }

    public void LoadKillScene()
    {
        Debug.Log("ENter Kill Scene");
        SceneManager.LoadScene(3);
    }

    public void LoadNMainScene()
    {

        SceneManager.LoadScene(4);
    }

    public void LoadBedroomScene()
    {

        SceneManager.LoadScene(5);
    }
    public void LoadReturnScene()
    {

        SceneManager.LoadScene(6);
    }
    public void LoadMenuScene()
    {

        SceneManager.LoadScene(0);
    }
}
