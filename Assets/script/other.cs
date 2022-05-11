using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class other : MonoBehaviour
{
    public GameObject job;
    public GameObject Dress;
    public GameObject Shop;

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
        SceneManager.LoadScene("Shop");
    }
    public void OnClickFinish2()
    {
        SceneManager.LoadScene("Dress");
    }
    public void OnClickFinish3()
    {
        SceneManager.LoadScene("job");
    }
}
