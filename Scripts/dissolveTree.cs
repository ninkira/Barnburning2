using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissolveTree : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    public GameObject trees;
    private GameObject stones;
   
    void Start()
    {
        
        mat = GetComponent<Renderer>().material;
        Debug.Log("mat: " + mat);
        stones = GameObject.Find("Steine");
        StartCoroutine(BurnCoroutine());
        
    }

    private void Update()
    {
      
        //   DisolveAnimation();
    }

    void DisolveAnimation(float floatNumber)
    {
        // mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time));
        mat.SetFloat("_DissolveAmount", floatNumber);
    }


    IEnumerator BurnCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Burn Trees Coroutine at timestamp : " + Time.time);
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
