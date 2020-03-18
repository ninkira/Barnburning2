using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class POI_script : MonoBehaviour
{
    public GameObject door;
    public int doorLock;
    public static int doorCounter;
    public Light highlighter;
    public GameObject canvasText;
    public GameObject tables;
    public GameObject button;
    public Texture btnSpriteHover;
    public Texture btnSpriteExit;
    public GameObject feuerzeugClick;
    public GameObject feuerzeugHover;
    public GameObject poiFeuer;
    void Start()
    {

     //   Debug.Log("Licht Test1 " + highlighter.enabled);
        highlighter.enabled = false;
        //   Debug.Log("Licht Test2 " + highlighter.enabled);
        canvasText.SetActive(false);

        //   tables.SetActive(false);
        feuerzeugClick.SetActive(false);
        feuerzeugHover.SetActive(false);
        poiFeuer.SetActive(false);

        if (doorCounter == doorLock) {
            door.SetActive(true);
            Debug.Log("Nichts passiert");
        } else
        {
            door.SetActive(false);
        }
        

        // door things
        Debug.Log("bin in start methode + object: " + gameObject);
 

    }
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("OnTriggerENter");
    }


    private void Update()
    {
              
    }

    public void ButtonHover()
    {
        Debug.Log("Button Hover");
        button.GetComponent<UnityEngine.UI.RawImage>().texture = btnSpriteHover;
        feuerzeugHover.SetActive(true);

    }

    public void ButtonExit()
    {
        button.GetComponent<UnityEngine.UI.RawImage>().texture = btnSpriteExit;
      
    }

 

 
    public void HighlightPOI()
    {
        Debug.Log("Highlight POI");
        highlighter.enabled = true;
        poiFeuer.SetActive(true);
        feuerzeugHover.SetActive(true);
    }

    public void LowlightPOI()
    {
        highlighter.enabled = false;
        poiFeuer.SetActive(false);
        feuerzeugHover.SetActive(false);
    }


    public void ShowCanvas() {
        Debug.Log("Show Canvas Function");
        Debug.Log("canvas status before change: " + canvasText.activeInHierarchy);
        poiFeuer.SetActive(false);
        canvasText.SetActive(true);
        Debug.Log("canvas status after change: " + canvasText.activeInHierarchy);

        tables.SetActive(false);
        tables.transform.localScale = new Vector3(0, 0, 0);
        
        canvasText.SetActive(true);

        doorCountMethod();

        Debug.Log("lock number: " + doorLock);
        Debug.Log("doorCounter +1 " + doorCounter);
        if (doorCounter >=  doorLock )
        {
            Debug.Log("unlock door");
            unlockDoor();
        }


        //   GameObject.Find("LightContainer").SetActive(false);
    }
    public void doorCountMethod()
    {
        Debug.Log("Test " + doorCounter);
        doorCounter += 1;
        Debug.Log(doorCounter);
      

    }
    public void HideCanvas()
    {
        Debug.Log("Hide Canvas Function");

        canvasText.SetActive(false);
     
        tables.transform.localScale = new Vector3(1, 1, 1);
        tables.SetActive(true);
        Debug.Log("Tables " + tables.activeInHierarchy);
        Debug.Log("Feuerzeug Click");
        feuerzeugClick.SetActive(true);
        //  GameObject.Find("LightContainer").SetActive(true);
    }

    public void unlockDoor()
    {
        door.SetActive(true);
    }
}

