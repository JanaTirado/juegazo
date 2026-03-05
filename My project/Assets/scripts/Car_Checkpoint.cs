using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Checkpoint : MonoBehaviour
{
    [HideInInspector] public Transform checkpoint;
    public Transform startPos;
    void Start()
    {
        checkpoint= startPos;
    }

    // Update is called once per frame
    void Update()
    {
        Respawn();
    }

    public void Respawn()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = checkpoint.position;
        }
    }
        
      
}
