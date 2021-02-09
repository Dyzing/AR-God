using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanExplosion : MonoBehaviour
{
    public Transform cratere;
    public GameObject explosionVolcanParticles;
    public int timer = 3;
    private bool doitExploser = false;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (doitExploser)
        {
            VolcanExplosionWithCoroutine();
        }
    }


    void VolcanExplosionWithCoroutine()
    {
        Instantiate(explosionVolcanParticles, cratere.position, Quaternion.identity);
        source.Play();
        doitExploser = false;
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(5);
            timer--;
        }
        timer = 3;
        doitExploser = true;
    }
}
