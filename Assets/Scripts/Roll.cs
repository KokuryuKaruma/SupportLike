using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{

    public GameObject RollObject;

    public void OnClick()
    {
        Vector2 pos = new Vector2(0.0f, -2.2f);
        Instantiate(RollObject, pos, Quaternion.identity);
    }
}
