using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<Car_Checkpoint>().checkpoint = transform;
        }
    }
    
       
}
