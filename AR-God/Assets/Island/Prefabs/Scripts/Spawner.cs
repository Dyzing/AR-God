using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Foodprefab;
    public GameObject FallingObject;
    public GameObject RecallParticles;

    public Vector3 center;
    public Vector3 size;
    public int nbMaxFood = 2;
    int nbCurrentFood = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnFood();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnFood()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2 / 2, size.x / 2), Random.Range(-size.y / 2 / 2, size.y / 2), Random.Range(-size.z / 2 / 2, size.z / 2));
        Transform[] FoodprefabChildren = Foodprefab.GetComponentsInChildren<Transform>();
        int randChild = Random.Range(1, FoodprefabChildren.Length);
        GameObject tmp = Instantiate(FoodprefabChildren[randChild].gameObject, pos, Quaternion.identity);
        Instantiate(RecallParticles, pos, Quaternion.identity);
        tmp.transform.SetParent(FallingObject.transform);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }

    public void SPAWN_BUTTON()
    {
        nbCurrentFood = FallingObject.GetComponentsInChildren<Transform>().Length - 1;
        if (nbCurrentFood < nbMaxFood)
        {
            SpawnFood();
        }
    }
}
