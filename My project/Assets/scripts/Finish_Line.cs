using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Line : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger activado por: " + other.name + " | Tag: " + other.tag);

        if (other.CompareTag("Player"))
        {
            Finish_Manager.Instance.PlayerWon();
        }
    }
}