using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : MonoBehaviour
{
    public int x = 1;
    public int y = 8;

    // Start is called before the first frame update
    void Start()
    {
        while (x < 8)
        {
            print(x++);
        }
        if (y == 8)
        {
            print("It's my birthday month!");
        }
    }


        public int day = 1;
    public int birthday = 6;

        void Update()

    {
        while (day < 6)
        {
            print(day++);
        }

        if(birthday ==6)
        {
            print("It's my birthday");
        }

    }
    
}