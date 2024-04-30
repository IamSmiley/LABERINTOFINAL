using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float timeToAdd = 10f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            TIMER.instance.AddTime(timeToAdd); 
            Destroy(gameObject); 
        }
    }

}