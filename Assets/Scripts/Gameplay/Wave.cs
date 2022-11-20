using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Wave : MonoBehaviour
{
    private int _nbr;
    private EntityStats _stat;
    private bool _end;

    public Wave(int roundNbr)
    {
        _nbr = Random.Range(1,4);
        _stat = new EntityStats(Random.Range(30,51)+(roundNbr*2),1,Random.Range(4,7)+roundNbr);
        _end = false;
    }
}
