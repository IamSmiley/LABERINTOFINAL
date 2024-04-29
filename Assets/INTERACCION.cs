using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class INTERACCION : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text texto;
    public string mensaje;

    void Start()
    {
        PanelOff();
    }

    public void PanelOn()
    {
        panel.SetActive(true);
        texto.text = mensaje ;

    }
    public void PanelOff()
    {
        panel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PanelOn();
        }
    }

    void OnTriggerExit(Collider other)
    {
        PanelOff();
    }

}
