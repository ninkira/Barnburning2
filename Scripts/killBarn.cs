using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBarn : MonoBehaviour
{
    // Start is called before the first frame update

    Material mat;
  
    public GameObject barn;
    public Material materialTwo;
    public GameObject text1;
    public GameObject text2;

   // public dissolveTree dTree;
    public GameObject fireSound;

    public GameObject smoke;
    public GameObject scheunenLicht;
    public GameObject smoke1;
    public GameObject smoke2;
    public GameObject explosion;
    public GameObject fire;
    public GameObject[] objectArray;

    public GameObject trees;
    public GameObject[] kegelArray;
    public GameObject[] kroneArray;
    public GameObject[] zylinderArray;
    private GameObject stones;
  

    void Start()
    {
        scheunenLicht.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        // mat = GetComponent<Renderer>().material;
        kegelArray = GameObject.FindGameObjectsWithTag("Kegel");
        zylinderArray = GameObject.FindGameObjectsWithTag("Zylinder");
        kroneArray = GameObject.FindGameObjectsWithTag("Krone");



        stones = GameObject.Find("Steine");

        fireSound.SetActive(false);
        smoke.SetActive(false);
        smoke1.SetActive(false);
        smoke2.SetActive(false);
        explosion.SetActive(false);
        fire.SetActive(false);

        DisolveTreeAnimation(0.0f);
        DisolveAnimation(0.0f);
    

    }

   

    // Start is called before the first frame update
  

    public void setFire()
    {
        Debug.Log("Enter setFire()");
        fireSound.SetActive(true);
        fire.SetActive(true);
        smoke.SetActive(true);
        smoke1.SetActive(true);
        smoke2.SetActive(true);
        explosion.SetActive(true);
        Debug.Log("Starte Coroutine");

        scheunenLicht.SetActive(true);
        // start animation 
        StartCoroutine(BurnBarnCoroutine());
        StartCoroutine(BurnTreesCoroutine());

    }

    void DisolveAnimation(float floatNumber)
    {
        for (int i = 0; i < objectArray.Length; i++)
        {
            objectArray[i].GetComponent<Renderer>().material.SetFloat("_DissolveAmount", floatNumber);
        }
        // mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time));
       // mat.SetFloat("_DissolveAmount", floatNumber);
    }
    void DisolveTreeAnimation(float floatNumber)
    {
        for (int i = 0; i < kegelArray.Length; i++)
        {
            kegelArray[i].GetComponent<Renderer>().material.SetFloat("_DissolveAmount", floatNumber);
                   }
        for (int a = 0; a < zylinderArray.Length; a++)
        {
            zylinderArray[a].GetComponent<Renderer>().material.SetFloat("_DissolveAmount", floatNumber);
                       
        }
        for (int c = 0; c < kroneArray.Length; c++)
        {
            kroneArray[c].GetComponent<Renderer>().material.SetFloat("_DissolveAmount", floatNumber);
        }
        // mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time));

    }



    IEnumerator BurnBarnCoroutine()
    {
        Debug.Log("In killBarnCoroutine");
        //Print the time of when the function is first called.
        if (fire.activeInHierarchy == true)
        {
            yield return new WaitForSeconds(3);
            Debug.Log("First new Dissolve Val");
            DisolveAnimation(0.0f);
            //yield on a new YieldInstruction that waits for 5 seconds.
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


            // trees.SetActive(false);
            yield return new WaitForSeconds(2.5f);
          
            RenderSettings.skybox = materialTwo;
            yield return new WaitForSeconds(1.5f);
           
            Debug.Log("Text1");
            text1.SetActive(true);

            yield return new WaitForSeconds(4.0f);
            text1.SetActive(false);
             Debug.Log("set text1 unactive");
            text2.SetActive(true);
            barn.SetActive(false);
            //After we have waited 5 seconds print the time again.
            Debug.Log("Finished BarnBurning Coroutine at timestamp : " + Time.time);
        } else
        {
            Debug.Log("here to fill ín new content");
        }
    }



    IEnumerator BurnTreesCoroutine()
    {
        if (fire.activeInHierarchy == true)
        {
            //Print the time of when the function is first called.
            Debug.Log("Started Burn Click Trees Coroutine in killBarn : " + Time.time);
            yield return new WaitForSeconds(0);

            DisolveTreeAnimation(0.0f);
           
            yield return new WaitForSeconds(6.5f);

            DisolveTreeAnimation(0.00f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.05f);
           
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.1f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.15f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.2f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.25f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.3f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.35f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.4f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.45f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.5f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.55f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.6f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.65f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.700f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.70f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.75f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.80f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.85f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.9f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(0.95f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(1.0f);
            yield return new WaitForSeconds(0.04f);
            DisolveTreeAnimation(1.05f);
            yield return new WaitForSeconds(0.03f);
            DisolveTreeAnimation(1.1f);


            trees.SetActive(false);
            stones.SetActive(false);
            //After we have waited 5 seconds print the time again.
            Debug.Log("Finished Brun Trees Coroutine at timestamp : " + Time.time);
        }
    }
}
