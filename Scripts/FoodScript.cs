using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject foodText;
    public GameObject appleText;

    void Start()
    {
        foodText = GameObject.Find("FoodCanvas");
        appleText = GameObject.Find("AppleCanvas");
        Debug.Log("FoodCanvas " + foodText);
        foodText.SetActive(false);
    }
    public void OnEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnClick()
    {
        foodText.SetActive(true);
        Debug.Log("Disapparenace of AppleCanvas");
       
        appleText.SetActive(false);
        GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("Appearance of the Food Canvas.");
        
        
    }

    public void OnExitChange()
    {

        GetComponent<Renderer>().material.color = Color.white;
    }
}


