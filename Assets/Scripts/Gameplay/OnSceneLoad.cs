using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSceneLoad : MonoBehaviour
{
    void Awake()
    {
        GameManager.GM.GetSpawnPointsAndWave();
    }
}
