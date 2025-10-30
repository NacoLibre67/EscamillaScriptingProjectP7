using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesandfunctions : MonoBehaviour
{
    //Creating An interger
    public int myint = 6;
    // Start is called before the first frame update
    void Start()
    {
        //running my int variable thru the function 
        myint = MultiplyByTwo(myint);
        Debug.Log(myint);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MultiplyByTwo(int number);
   {
    int result;
    result = number* 2;
      return result;
   }
}


