using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public GameObject appleText;

    void Start()
    {
        appleText = GameObject.Find("AppleCanvas");
        Debug.Log("Apple Canvas " + appleText);
        appleText.SetActive(false);
    }
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("OnTriggerENter");
    }

    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("Appearance of the Apple Canvas.");
        appleText.SetActive(true);
        Debug.Log("OnTriggerENter");
    }

    public void White()
    {
   
        GetComponent<Renderer>().material.color = Color.white;
        Debug.Log("OnTriggerENter");
    }
}
