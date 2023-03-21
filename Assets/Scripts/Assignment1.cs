using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    public int x = 22;

    // Start is called before the first frame update
    void Start()
    {
        while (x <= 100)
        {
            print(x);
            x = x + 2;
        }
    }
}