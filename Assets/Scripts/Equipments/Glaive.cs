using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glaive : Equipment
{
    public override GameObject obj { get; set; }
    public override string Name { get; set; }
    public override string Description { get; set; }
    public override Capacity[] Capacities { get; set; }

    private void Start()
    {
        Name = "Glaive";
        Description = "Roman well balanced short sword.";
    }
}
