using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UIElements;

public class ifStatements : MonoBehaviour
{
    float coffeeTemperatrure = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemerature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperatrure -= Time.deltaTime * 5f;
    }

    void TemperatureTest() 
    {

        if (coffeeTemperatrure > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        
        }

        else if (coffeeTemperatrure < coldLimitTemerature)
        {
            print("Coffee is too cold.");
        }
        else 
        {
            print("Coffee is just right.");
        }


    }
         
}