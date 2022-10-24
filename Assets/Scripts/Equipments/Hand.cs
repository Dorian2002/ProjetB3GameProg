using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerScripts
{
    public class Hand : Equipment
    {
        public override string Name { get; set; } = "Hand";
        public override string Description { get; set; } = "Just your hand";
        public override string Owner { get; set; }
        public override Animator anim { get; set; }

        public override List<Dropdown.OptionData> Capacities1 { get; set; } = new List<Dropdown.OptionData>()
        {

        };
        public override List<Dropdown.OptionData> Capacities2 { get; set; } = new List<Dropdown.OptionData>()
        {

        };
        public override List<Dropdown.OptionData> Capacities3 { get; set; } = new List<Dropdown.OptionData>()
        {

        };

    }
}
