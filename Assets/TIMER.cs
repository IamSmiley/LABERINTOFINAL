using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public static TIMER instance;
    public Text contador;
    private float tiempo = 60f;
    void Start()
    {
        contador.text = "" + tiempo;
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo-= Time.deltaTime;
        contador.text = "" + tiempo.ToString("f0");

        if(tiempo < 0)
        {
            contador.text = "0";
            SceneManager.LoadScene("GAMEOVER");
        }
    }
    public void AddTime(float timeToAdd)
    {
        tiempo += timeToAdd; 
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject); 
            return;
        }
    }
}