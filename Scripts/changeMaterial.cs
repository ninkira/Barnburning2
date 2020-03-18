using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    public Material materialOne;
    public Material materialTwo;
    public Material materialThree;
    public Material materialFour;
    public Material materialFive;
    
    public GameObject chooseUI;

    public GameObject fireEffects;
    public GameObject clip01;
    public GameObject clip02;
    public GameObject clip03;
    public GameObject clip04;
    public GameObject streichholz;
    public GameObject sirene;
    public GameObject feuer;
    // Start is called before the first frame update
    public Light schuhlicht;
    public Light feuerlicht;
    public GameObject schuh;
    public GameObject feuerloescher;
    void Start()
    {
        StartCoroutine(psychoAnimation());
        chooseUI.SetActive(false);
       clip01 = GameObject.Find("Clip01");
        clip01.SetActive(false);
        clip02 = GameObject.Find("Clip02");
        clip02.SetActive(false);
        clip03 = GameObject.Find("Clip03");
        clip03.SetActive(false);
        clip04 = GameObject.Find("Clip04");
        clip04.SetActive(false);
        streichholz = GameObject.Find("StreicholzSound");
        streichholz.SetActive(false);
        sirene = GameObject.Find("SirenenSound");
        sirene.SetActive(false);
        feuer = GameObject.Find("FeuerSound");
        feuer.SetActive(false);

        schuhlicht.enabled = false;
        feuerlicht.enabled = false;

        feuerloescher.SetActive(false);
        schuh.SetActive(false);
        fireEffects.SetActive(false);
    }

    IEnumerator psychoAnimation()
    {
        // wait for 1 second
        Debug.Log("Time " + Time.time);
        Debug.Log("psychoanimation starts now");
        yield return new WaitForSeconds(1.0f);

        Debug.Log("First Part");
        clip01.SetActive(true);
        RenderSettings.skybox = materialOne;
        yield return new WaitForSeconds(6.8f);
        Debug.Log("Streichholzsound");
        streichholz.SetActive(true);
        yield return new WaitForSeconds(10.2f); // OG Val 22

        Debug.Log("Second Part");
        clip01.SetActive(false);
        clip02.SetActive(true);
        feuer.SetActive(true);
        fireEffects.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        sirene.SetActive(true);

        RenderSettings.skybox = materialTwo;
        yield return new WaitForSeconds(15.0f);

        clip02.SetActive(false);
        clip03.SetActive(true);
        Debug.Log("Third Part");
        RenderSettings.skybox = materialThree;
        yield return new WaitForSeconds(25.0f);
        clip03.SetActive(false);
        clip04.SetActive(true);

        Debug.Log("Fourth Part");
        RenderSettings.skybox = materialFour;
        yield return new WaitForSeconds(16.0f);
       
        Debug.Log("Enter final screen");
        RenderSettings.skybox = materialFive;
        Debug.Log("set UI active");
        clip04.SetActive(false);
        sirene.SetActive(false);
        schuhlicht.enabled = true;
        feuerlicht.enabled = true;
        feuerloescher.SetActive(true);
        schuh.SetActive(true);
        chooseUI.SetActive(true);




        Debug.Log("Animation dene");
    }
  
}
