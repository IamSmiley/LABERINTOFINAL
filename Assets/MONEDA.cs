using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float timeToAdd = 5f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            TIMER.instance.AddTime(timeToAdd); 
            Destroy(gameObject); 
        }
    }

}