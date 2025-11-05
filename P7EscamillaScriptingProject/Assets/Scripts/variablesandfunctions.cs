using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesandfunctions : MonoBehaviour
{
    int myInt = 6;

    void Start ()
    {
        myInt = MultiplyByTwo(myInt = 0);
        Debug.Log(myInt);
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }

}

  


