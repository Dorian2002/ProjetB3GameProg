using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerScripts
{
    public class Glaive : Equipment
    {
        public override string Name { get; set; } = "Glaive";
        public override string Description { get; set; } = "Roman well balanced short sword.";
        public override Animator anim { get; set; }
        public override EntityStats OwnerStats { get; set; }

        public override List<Dropdown.OptionData> Capacities1 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Heavy hit"),
        };
        public override List<Dropdown.OptionData> Capacities2 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Tornado"),
        };
        public override List<Dropdown.OptionData> Capacities3 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Last hope"),
        };

    }
}
