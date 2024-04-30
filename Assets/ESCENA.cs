using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESCENA : MonoBehaviour
{
    public void cambiarescena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
    public void EscenaJuego()
    {
        SceneManager.LoadScene("JUEGO");
    }
}
