using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    // Start is called before the first frame update

    public Material[] material;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple") {
            rend.sharedMaterial = material[1];
        } else
        {
            rend.sharedMaterial = material[2];
        }
    }
}
