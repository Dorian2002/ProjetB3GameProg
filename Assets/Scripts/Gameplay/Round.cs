using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    private List<Wave> _waves;
    private int _roundNbr;
    private bool _end;
    
    public Round(int roundNbr)
    {
        _waves = new List<Wave>();
        for (int i=0;i<=roundNbr+Random.Range(0,4)-Random.Range(0,4);i++)
        {
            _waves.Add(new Wave(roundNbr));
        }
        _roundNbr = roundNbr;
        _end = false;
    }
}
