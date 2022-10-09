using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlaiveShield_Drill : MonoBehaviour
{
    [SerializeField] private Rigidbody player;

    private void Start()
    {
        player = GetComponentInParent<Rigidbody>();
    }

    public void Drill()
    {
        player.AddForce(player.transform.forward * 600);
    }
}
