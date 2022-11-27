using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xpBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.GM.AddPlayerXp();
            Destroy(gameObject);
        }
            
    }
}
