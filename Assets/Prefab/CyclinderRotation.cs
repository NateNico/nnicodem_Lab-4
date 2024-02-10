using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclinderRotation : MonoBehaviour
{

    int delta = 10;
    float yRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform tr = this.GetComponent<Transform>();

        yRotation += delta; 
        tr.Rotate(0, yRotation, 0);
        
    }
}
