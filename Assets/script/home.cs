using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    public GameObject menu;
    public GameObject job;
    public GameObject Dress;
    public GameObject Shop;
    public GameObject close;

    void Start()
    {
        job.SetActive(false);
        Dress.SetActive(false);
        Shop.SetActive(false);
        close.SetActive(false);
    }
    public void OnClickFinish() 
    {
        menu.SetActive(false);
        job.SetActive(true);
        Dress.SetActive(true);
        Shop.SetActive(true);
        close.SetActive(true);

    
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
