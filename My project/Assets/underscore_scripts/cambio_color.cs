using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio_color : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
            // Cambiar el color del material
            gameObject.GetComponent<Renderer>().material.color = colorAleatorio;
            
        }
        
        
    }
}
