using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject objToTeleportTo;


    public void Teleport()
    {
        
        
            player.transform.position = objToTeleportTo.transform.position;
        
    }
}
