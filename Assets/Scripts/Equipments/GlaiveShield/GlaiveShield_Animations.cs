using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlaiveShield_Animations : MonoBehaviour
{
    [SerializeField] private Rigidbody playerBody;

    private void Start()
    {
        playerBody = GetComponentInParent<Rigidbody>();
    }

    public void Drill()
    {
        playerBody.AddForce(playerBody.transform.forward * 600);
    }
    
    public void Undefeated(bool start)
    {
        StartCoroutine(UseUndefeated());
    }

    private IEnumerator UseUndefeated()
    {
        playerBody.transform.localScale.Set(1.5f,1.5f,1.5f);
        yield return new WaitForSeconds(5);
        playerBody.transform.localScale.Set(1f,1f,1f);
    }
}


