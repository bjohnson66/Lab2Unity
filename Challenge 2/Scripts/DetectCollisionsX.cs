using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DetectCollisionsX : MonoBehaviour
{
    private int bounce_count = 3;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Dog"))
        {

            Destroy(gameObject);
        }
        if (bounce_count <= 0){
            Destroy(gameObject);
        }

        bounce_count--;
    }
}
