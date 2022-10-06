using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : MonoBehaviour
{
    public abstract GameObject obj { get; set; }
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract Capacity[] Capacities {get; set; }
}
