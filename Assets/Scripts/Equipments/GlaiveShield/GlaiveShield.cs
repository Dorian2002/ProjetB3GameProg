using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerScripts
{
    public class GlaiveShield : Equipment
    {
        public override string Name { get; set; } = "Glaive&Shield";
        public override string Description { get; set; } = "Roman short sword with a shield.";

        public override List<Dropdown.OptionData> Capacities1 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Heavy hit"),
            new Dropdown.OptionData("Great counter"),
            new Dropdown.OptionData("Drill"),
        };

        public override List<Dropdown.OptionData> Capacities2 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Tornado"),
            new Dropdown.OptionData("Undefeated"),
        };

        public override List<Dropdown.OptionData> Capacities3 { get; set; } = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData("Last hope"),
            new Dropdown.OptionData("Stampede"),
        };
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Ennemy"))
            {
                
            }
        }
    }
}
