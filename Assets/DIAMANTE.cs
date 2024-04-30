using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DIAMANTE : MonoBehaviour
{
    
    public string WIN;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
           
            SceneManager.LoadScene("WIN");
        }
    }
}