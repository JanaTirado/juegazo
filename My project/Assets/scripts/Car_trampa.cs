using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
 
    public float speed = 10f;
    public float turnSpeed = 100f;

    public Renderer carRenderer; 

    bool invertedControls = false;
    Color originalColor;

    void Start()
    {
        if (carRenderer != null)
        {
            originalColor = carRenderer.material.color;
        }
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        if (invertedControls)
        {
            turn *= -1;
        }

        transform.Translate(0, 0, move);
        transform.Rotate(0, turn, 0);
    }

    public void ActivateTrap(float duration)
    {
        StopAllCoroutines();
        StartCoroutine(TrapEffect(duration));
    }

    IEnumerator TrapEffect(float duration)
    {
        invertedControls = true;

        if (carRenderer != null)
        {
            carRenderer.material.color = Color.black;
        }

        yield return new WaitForSeconds(duration);

        invertedControls = false;

        if (carRenderer != null)
        {
            carRenderer.material.color = originalColor;
        }
    }
}
