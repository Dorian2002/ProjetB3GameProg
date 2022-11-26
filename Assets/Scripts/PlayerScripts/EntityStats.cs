using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats
{
    private string _owner;
    private int _level;
    private int _exp;
    private int _hp;
    private int _attackSpeed;
    private int _damages;

    public EntityStats(string owner)
    {
        _owner = owner;
        _level = 1;
        _exp = 0;
        _hp = 100;
        _attackSpeed = 1;
        _damages = 10;
    }
    
    public EntityStats(string owner, int hp, int attackspeed, int damages)
    {
        _owner = owner;
        _level = 1;
        _exp = 0;
        _hp = hp;
        _attackSpeed = attackspeed;
        _damages = damages;
    }

    public string GetOwner()
    {
        return _owner;
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
