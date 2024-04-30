using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public Text contador;
    private float tiempo = 10f;
    void Start()
    {
        contador.text = "" + tiempo;
    }

    // Update is called once per frame
    void Update()
    {

    }
}