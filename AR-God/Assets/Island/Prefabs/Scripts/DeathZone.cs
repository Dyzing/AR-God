using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Start is called before the first frame update
    Collider col;
    [SerializeField]
    private GameObject Particle;
    void Start()
    {
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            float time = 0;
            Instantiate(Particle, other.transform.position, other.transform.rotation);
            while (time < 5)
            {
                time += Time.deltaTime * 0.2f;
            }
            other.gameObject.SetActive(false);
        }

    }
}
