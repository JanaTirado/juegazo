using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Manager : MonoBehaviour
{
    
        public static Finish_Manager Instance;

        [Header("UI")]
        public GameObject winPanel; // Arrastra aquí el panel "Ganaste"

        private void Awake()
        {
            Instance = this;
            winPanel.SetActive(false); // Panel oculto al inicio
        }

        public void PlayerWon()
        {
            winPanel.SetActive(true);       // Muestra la pantalla
            Time.timeScale = 0f;            // Pausa el juego
        }
    }