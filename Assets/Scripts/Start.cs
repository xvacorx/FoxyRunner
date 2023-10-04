using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public string nombreDeEscenaACargar = "Runner";

    public void CambiarEscenaOnClick()
    {
        SceneManager.LoadScene(nombreDeEscenaACargar);
    }
}
