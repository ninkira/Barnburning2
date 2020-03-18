using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheunenScript : MonoBehaviour
{

    public GameObject fireSound;

    public GameObject smoke;
    public GameObject explosion;


    // Start is called before the first frame update
    void Start()
    {
        fireSound.SetActive(false);
       
        smoke.SetActive(false);
        explosion.SetActive(false);
       
    }

    public void setFire()
    {
        fireSound.SetActive(true);
        
        smoke.SetActive(true);
        explosion.SetActive(true);
       
    }
    // Update is called once per frame

   
}
