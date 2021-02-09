using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    private Transform me;
    public Transform firstPoint;
    public Transform secondPoint;
    bool first = true;
    public float speed = 3.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        me = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (first)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, firstPoint.position, step);
            if(transform.position == firstPoint.position)
            {
                first = false;
            }
        }
        else
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, secondPoint.position, step);
            if (transform.position == secondPoint.position)
            {
                first = true ;
            }
        }
        /*me.position = new Vector3(me.position );
        rb.MovePosition((Vector3.Lerp(firstPoint.position, secondPoint.position, Time.deltaTime)));*/
    }
}
