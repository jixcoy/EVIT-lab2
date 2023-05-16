using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int ind = Random.Range(0, prefabs.Length);
            Vector3 spawn = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
            Instantiate(prefabs[ind], spawn, prefabs[ind].transform.rotation);            
        }
    }
}
