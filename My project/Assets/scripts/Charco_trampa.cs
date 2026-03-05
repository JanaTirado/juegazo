using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charco_trampa : MonoBehaviour
{
   
    public float effectDuration = 3f;

    private void OnTriggerEnter(Collider other)
    {
        CarController car = other.GetComponent<CarController>();

        if (car != null)
        {
            car.ActivateTrap(effectDuration);
        }
    }
}
