using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float Speed = 5f;
    float LifeTime = 0f;
    float MaxLifeTime = 7f;

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
