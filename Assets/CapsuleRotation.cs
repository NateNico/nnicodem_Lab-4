using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapselRotation : MonoBehaviour
{

    int delta = 10;
    float zRotation = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform tr = this.GetComponent<Transform>();

        zRotation += delta;
        tr.Rotate(0, 0, zRotation);

    }
}
