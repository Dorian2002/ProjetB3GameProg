using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Capacity : MonoBehaviour
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract int Cooldown { get; set; }
    public abstract void UseCapacity();
}
