using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats : ICloneable
{
    private string _owner;
    private int _level;
    private int _exp;
    private int _hp;
    private int _hpMax;
    private int _attackSpeed;
    private int _damages;

    public EntityStats(string owner)
    {
        _owner = owner;
        _level = 1;
        _exp = 0;
        _hpMax = 100;
        _hp = _hpMax;
        _attackSpeed = 1;
        _damages = 10;
    }
    
    public EntityStats(string owner, int hp, int attackspeed, int damages)
    {
        _owner = owner;
        _level = 1;
        _exp = 0;
        _hpMax = hp;
        _hp = _hpMax;
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
    public int GetHpMax()
    {
        return _hpMax;
    }

    public void Damage(int damage)
    {
        _hp -= damage;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public void AddXp()
    {
        _exp += 100;
        if (_exp >= 200)
        {
            _exp = 0;
            _level += 1;
            GameManager.GM.player.LevelUp();
        }
    }
    
    public void UpgradeDamages()
    {
        _damages += 2;
        RegenHp();
    }
    public void UpgradeMaxHp()
    {
        _hpMax += 10;
        RegenHp();
    }

    private void RegenHp()
    {
        if (_hp + 25 >= _hpMax)
        {
            _hp = _hpMax;
        }
        else
        {
            _hp += 25;
        }
    }
}
