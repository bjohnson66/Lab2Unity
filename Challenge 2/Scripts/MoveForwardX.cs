using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoveForwardX : MonoBehaviour
{
    public float speed;
    public bool isBall = false;
    private void Start()
    {
        if (isBall)
        {
            speed = Random.Range(-2, 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
