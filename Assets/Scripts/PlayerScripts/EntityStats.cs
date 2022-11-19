using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats : MonoBehaviour
{
    [SerializeField] private string owner;
    private int _level = 0;
    private int _exp = 0;
    private int _hp = 100;
    private int _attackSpeed = 1;
    private int _damages = 10;

    private void Start()
    {
        _damages = 10;
    }

    public string GetOwner()
    {
        return owner;
    }

    public int GetDamage()
    {
        return _damages;
    }
    
    public int GetHp()
    {
        return _hp;
    }

    public void Damage(int damage)
    {
        _hp -= damage;
    }
}
