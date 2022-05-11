using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    public float time = 1.0f;

    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
