using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Wave
{
    private int _nbr;
    private EntityStats _stat;
    private bool _end;

    public Wave(int waveNbr)
    {
        _nbr = Random.Range(1,4);
        _stat = new EntityStats("Ennemy",Random.Range(30,51)+(waveNbr*2),1,Random.Range(4,7)+waveNbr);
        _end = false;
    }

    public int GetNbr()
    {
        return _nbr;
    }

    public EntityStats GetStats()
    {
        return _stat;
    }
}
