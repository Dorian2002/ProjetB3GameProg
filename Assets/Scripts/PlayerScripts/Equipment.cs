using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerScripts
{
    public abstract class Equipment : MonoBehaviour
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract Capacity[] Capacities {get; set; }
    }
}

