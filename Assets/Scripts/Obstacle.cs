using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float Speed = 5f;
    float LifeTime = 0f;
    float MaxLifeTime = 10f;

    private void Update()
    {
        transform.position -= new Vector3(Speed * (Time.deltaTime), 0, 0);
        LifeTime += Time.deltaTime;

        if (LifeTime >= MaxLifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}
