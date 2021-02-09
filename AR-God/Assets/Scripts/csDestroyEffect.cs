using UnityEngine;
using System.Collections;

public class csDestroyEffect : MonoBehaviour {
    float time = 0.0f;
    void Update ()
    {
        time += Time.deltaTime;
	    if(time > 5)
        {
            Destroy(gameObject);
        }
	}
}
