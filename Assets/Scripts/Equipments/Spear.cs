using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerScripts
{
    public class Spear : Equipment
    {
        public override string Name { get; set; } = "Spear";
        public override string Description { get; set; } = "Roman long and pointed spear.";
        public override List<Dropdown.OptionData> Capacities1 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Wrath"),
        };
        public override List<Dropdown.OptionData> Capacities2 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Double reaper"),
        };
        public override List<Dropdown.OptionData> Capacities3 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Lightweight")
        };
    }
}
