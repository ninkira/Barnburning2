using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideCanvas : MonoBehaviour
{
    // Start is called before the first frame update

    
    public GameObject canvasText;
    public GameObject tables;
    public GameObject feuerzeugClick;

    public GameObject door;
    public int doorLock;
    public static int doorCounter;
    public Light highlighter;
 
    public GameObject feuerzeugHover;
    public GameObject poiFeuer;

    public void HideCanvas()
    {
        Debug.Log("Hide Canvas Function");

        canvasText.SetActive(false);

        tables.transform.localScale = new Vector3(1, 1, 1);
        tables.SetActive(true);
        Debug.Log("Tables " + tables.activeInHierarchy);
        feuerzeugClick.SetActive(true);
        //  GameObject.Find("LightContainer").SetActive(true);
    }


    public void ShowCanvas()
    {
        Debug.Log("Show Canvas hidecanvas Function");
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
        if (doorCounter >= doorLock)
        {
            Debug.Log("unlock door");
            unlockDoor();
        }
    }

        public void doorCountMethod()
        {
            Debug.Log("Test " + doorCounter);
            doorCounter += 1;
            Debug.Log(doorCounter);


        }
        public void unlockDoor()
        {
            door.SetActive(true);
        }
        //   GameObject.Find("LightContainer").SetActive(false);
    }
 
