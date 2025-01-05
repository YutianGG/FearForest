using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    private int time = 20;
    void Update()
    {
        if (time < 0)
        {
            Destroy(gameObject);
        }
        else time--;
    }
}
