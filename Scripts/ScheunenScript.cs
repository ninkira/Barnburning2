using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheunenScript : MonoBehaviour
{

    public GameObject fireSound;
    public GameObject fire;
    public GameObject smoke;
    public GameObject explosion;
    public GameObject brief;

    // Start is called before the first frame update
    void Start()
    {
        fireSound.SetActive(false);
        fire.SetActive(false);
        smoke.SetActive(false);
        explosion.SetActive(false);
        brief.SetActive(false);
    }

    public void setFire()
    {
        fireSound.SetActive(true);
        fire.SetActive(true);
        smoke.SetActive(true);
        explosion.SetActive(true);
        brief.SetActive(true);
    }
    // Update is called once per frame
   
}
