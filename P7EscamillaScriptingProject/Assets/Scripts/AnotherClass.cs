using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;

    private int stapler;
    private int sellotape;

    // Start is called before the first frame update
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    } 
        
    
    
    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total:" + answer);
    }
}
