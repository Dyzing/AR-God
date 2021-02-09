using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody[] rbs;
    void Start()
    {
        rbs = GetComponentsInChildren<Rigidbody>();
    }

    public void OntargetFound()
    {
        foreach(Rigidbody rb in rbs)
        {
            rb.isKinematic = false;
        }
    }

    public void OntargetLost()
    {
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = true;
        }
    }
}


