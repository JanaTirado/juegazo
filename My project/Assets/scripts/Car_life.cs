using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLife : MonoBehaviour
{
    public int vidas = 3;
    public GameObject pantallaMuerte;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie") || collision.gameObject.CompareTag("Cono"))
        {
            vidas--;

            Debug.Log("Vidas restantes: " + vidas);

            if (vidas <= 0)
            {
                Morir();
            }
        }
    }

    void Morir()
    {
        pantallaMuerte.SetActive(true);
        Time.timeScale = 0f; // pausa el juego
    }
}
