using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour
{
    public GameObject closed;
    public GameObject menu;
    public GameObject Shop;
    public GameObject Dress;
    public GameObject job;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickFinish()
    {
        closed.SetActive(false);
        job.SetActive(false);
        Dress.SetActive(false);
        Shop.SetActive(false);
        menu.SetActive(true);
    }
}
