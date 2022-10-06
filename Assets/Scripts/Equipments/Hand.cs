using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerScripts
{
    public class Hand : Equipment
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override Capacity[] Capacities { get; set; }

        private void Start()
        {
            Name = "Hand";
            Description = "Just your hand";
        }
    }
}
