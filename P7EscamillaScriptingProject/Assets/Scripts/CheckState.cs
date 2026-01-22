using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.VisualElement;

public class CheckState : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myObject;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Active Self:" + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}
