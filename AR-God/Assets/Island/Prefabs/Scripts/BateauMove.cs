using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateauMove : MonoBehaviour
{
    public Transform target;
    public Transform tmp;
    public Transform Quai;
    bool found = false;
    [Range(5f, 20f)]
    public float runSpeed;
    float step;
    public int timer = 5;

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

        if (Vector3.Distance(tmp.position, Quai.position) < 0.1)
        {
            BateauStop();
        }
        
    }

    void BateauStop()
    {
        transform.position = Quai.position;
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while (timer > 0)
        {

            yield return new WaitForSeconds(4);
            timer--;
        }
        timer = 5;
        found = false;
    }
}
