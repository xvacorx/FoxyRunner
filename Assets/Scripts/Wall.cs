using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Wall : MonoBehaviour
{

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Barrier()
    {
        gameObject.SetActive(true);
    }
}
