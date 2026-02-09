using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroycomponent : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
