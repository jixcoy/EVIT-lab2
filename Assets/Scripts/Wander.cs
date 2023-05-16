using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
// TODO: Stop objects from falling off edge. Use velocity or force instead of translations

public class Wander : MonoBehaviour
{
    public float rotateMultiplier;
    public int rotateDirection;
    public int forceValue;
    private Vector3[] rotationDirections = { Vector3.up, Vector3.down };
    private Rigidbody rb;
    

    private void Start()
    {
        // Starts wander coroutine
        StartCoroutine(StartWander());
        rb = GetComponent<Rigidbody>();
    }


    IEnumerator StartWander()
    {
        // never ending movement in a circle 
        while (true)
        {
            
            rotateMultiplier = Random.Range(1, 5);

            rotateDirection = Random.Range(0, 2);
            
            transform.Rotate(Vector3.up, 10 * rotateMultiplier);
            transform.Translate(Vector3.forward * 2);

            yield return new WaitForSeconds(1.0f);

        }
    }
}
