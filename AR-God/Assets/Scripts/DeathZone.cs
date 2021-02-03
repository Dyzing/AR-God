using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Start is called before the first frame update
    Collider col;
    void Start()
    {
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
