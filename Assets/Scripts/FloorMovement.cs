using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    public float offsetX = 22f;
    public float ScrollSpeed = 6.0f;  // Velocidad inicial de desplazamiento
    public float accelerationRate = 0.5f;    // Tasa de aceleración
    private float timeElapsed = 0f;        // Tiempo transcurrido desde el inicio

    bool active = true;

    void Update()
    {
        while (active)
        {
            // Aumenta el tiempo transcurrido
            timeElapsed += Time.deltaTime;

            // Calcula la velocidad de desplazamiento en función del tiempo transcurrido
            float currentScrollSpeed = ScrollSpeed + accelerationRate * timeElapsed;

            // Mueve el objeto con la velocidad calculada
            transform.Translate(Vector2.left * currentScrollSpeed * Time.deltaTime);

            if (transform.position.x <= -offsetX)
            {
                transform.position = new Vector3(offsetX, transform.position.y, transform.position.z);
            }
        }
    }
}