using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    float offsetX = 21f;
    float speed = 5f;

    private void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x <= -offsetX)
        {
            transform.position = new Vector3(offsetX, transform.position.y, transform.position.z);
        }
    }
}
