using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateauMove : MonoBehaviour
{
    public Transform target;
    public GameObject bateau;
    public Transform tmp;

    [Range(3f, 10f)]
    public float runSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        tmp.LookAt(target);
        tmp.Rotate(0, -90, 0);
        tmp.RotateAround(target.position, target.transform.up, runSpeed * Time.deltaTime);
        tmp.eulerAngles = new Vector3(0, tmp.eulerAngles.y, 0);
    }
}
