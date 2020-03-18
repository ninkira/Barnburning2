using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disolvetreeclick : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    public GameObject trees;
    public GameObject[] kegelArray;
    public GameObject[] kroneArray;
    public GameObject[] zylinderArray;
    private GameObject stones;
    public GameObject fireObject;

    void Start()
    {
       /* kegelArray = GameObject.FindGameObjectsWithTag("Kegel");
       zylinderArray = GameObject.FindGameObjectsWithTag("Zylinder");
       kroneArray = GameObject.FindGameObjectsWithTag("Krone");


     
        stones = GameObject.Find("Steine");
     //   StartCoroutine(BurnTreesCoroutine());
        DisolveAnimation(0.0f);
        */
    }

    private void Update()
    {

        //   DisolveAnimation();
    }
    /*
    void DisolveAnimation(float floatNumber)
    {
        for (int i = 0; i <kegelArray.Length; i++)
        {
            for (int a = 0; a < zylinderArray.Length; a++)
            {
                for (int c = 0; c < kroneArray.Length; c++)
                {
                    kegelArray[i].GetComponent<Renderer>().material.SetFloat("_DissolveAmount", floatNumber);
                    zylinderArray[a].GetComponent<Renderer>().material.SetFloat("_DissolveAmount", floatNumber);
                   kroneArray[c].GetComponent<Renderer>().material.SetFloat("_DissolveAmount", floatNumber);
                }
                Debug.Log("KegelArray Iterating: " + kegelArray[i]);
               
            }
            
        }
        // mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time));
       
    }


    IEnumerator BurnTreesCoroutine()
    {
        if (fireObject.activeInHierarchy == true)
        {
            //Print the time of when the function is first called.
            Debug.Log("Started Burn Click Trees Coroutine at timestamp : " + Time.time);
            yield return new WaitForSeconds(0);

            DisolveAnimation(0.0f);
            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(6.5f);

            DisolveAnimation(0.00f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.05f);
            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.1f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.15f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.2f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.25f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.3f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.35f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.4f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.45f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.5f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.55f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.6f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.65f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.700f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.70f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.75f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.80f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.85f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.9f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(0.95f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(1.0f);
            yield return new WaitForSeconds(0.04f);
            DisolveAnimation(1.05f);
            yield return new WaitForSeconds(0.03f);
            DisolveAnimation(1.1f);


            trees.SetActive(false);
            stones.SetActive(false);
            //After we have waited 5 seconds print the time again.
            Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        }
    }
    */
}
