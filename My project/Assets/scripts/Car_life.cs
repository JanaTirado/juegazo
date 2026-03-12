using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarLife : MonoBehaviour
{
    public int vidas = 3;
    private GameObject pantallaMuerte;

    void Start()
    {
        pantallaMuerte = GameObject.Find("PantallaMuerte");

        if (pantallaMuerte != null)
        {
            pantallaMuerte.SetActive(false);
        }
    }

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
        if (pantallaMuerte != null)
        {
            pantallaMuerte.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}