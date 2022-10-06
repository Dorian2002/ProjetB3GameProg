using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = Instantiate(Resources.Load("Prefabs/Player") as GameObject);
    }
}
