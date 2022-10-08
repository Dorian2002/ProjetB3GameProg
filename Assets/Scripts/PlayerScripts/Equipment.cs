using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerScripts
{
    public abstract class Equipment : MonoBehaviour
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract List<Dropdown.OptionData> Capacities1 { get; set; }
        public abstract List<Dropdown.OptionData> Capacities2 { get; set; }
        public abstract List<Dropdown.OptionData> Capacities3 { get; set; }
    }
}

