using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CarCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cono") || other.CompareTag("Zombie"))
        {
            GameManager.instance.PerderVida();
            Destroy(other.gameObject);
        }
    }
}
