using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterScript : MonoBehaviour
{

    public GameObject letterText;
    
    void Start()
    {
        
        letterText = GameObject.Find("LetterCanvas");
        Debug.Log("letterCanvas " + letterText);
        letterText.SetActive(false);
    }
    public void letterEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void letterClick()
    {
        letterText.SetActive(true);
     
        GetComponent<Renderer>().material.color = Color.blue;



    }

    public void letterExit()
    {

        GetComponent<Renderer>().material.color = Color.white;
    }
}
