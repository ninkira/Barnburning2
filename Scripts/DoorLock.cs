using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door;
    public int doorCounter;
    void Start()
    {
        doorCounter = 0;
        Debug.Log("Counter Intitaliser: " + doorCounter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
