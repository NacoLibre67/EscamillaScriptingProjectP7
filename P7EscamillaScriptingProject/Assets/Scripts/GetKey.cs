using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
       bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);
        if (down)
        {
            Debug.Log("Get key Down is: " + down);

        }
        else if (held)
        {
            Debug.Log("Get held is: " + held);
        }
        else if (up)
        {
            Debug.Log("Get key Up is: " + up);
        }
        else
        {
            Debug.Log("Get key is down: " + down);
            Debug.Log("Get key is: " + held);
            Debug.Log("Get key Up is: " + up); 
        }
    }
}
