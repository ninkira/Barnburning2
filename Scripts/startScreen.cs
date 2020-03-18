using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScreen : MonoBehaviour
{

    public GameObject fireEffects;
    public GameObject mainMenu;
    public GameObject instructions;
    public GameObject credits;
    // Start is called before the first frame update
    void Start()
    {
        instructions.SetActive(false);
    }
    // Update is called once per frame
   
public void GetInstructions(){
        Debug.Log("isntructions pre status: " + instructions.activeInHierarchy);
        Debug.Log("GetInstructions methode");
        instructions.SetActive(true);
        Debug.Log("isntructions status: " + instructions.activeInHierarchy);
        mainMenu.SetActive(false);
        credits.SetActive(false);
        fireEffects.SetActive(false);

   

    }
    public void GetCredits()
    {  Debug.Log("credits pre status: " +credits.activeInHierarchy);
        credits.SetActive(true);
        Debug.Log("credits status: " + credits.activeInHierarchy);

        mainMenu.SetActive(false);
        instructions.SetActive(false);
        fireEffects.SetActive(false);
       
    }
    public void GetMenu()
    {
        if(instructions.activeInHierarchy == true)
        {
            instructions.SetActive(false);
        } else if (credits.activeInHierarchy == true)
        {
            credits.SetActive(false);
        }
        mainMenu.SetActive(true);
        fireEffects.SetActive(true);

    }
}
