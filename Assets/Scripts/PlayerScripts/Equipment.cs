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
        public abstract string Owner { get; set; }
        public abstract Animator anim { get; set; }
        
        private void OnTriggerEnter(Collider other)
        {
            tag = other.tag;
            if (Owner.Equals("Ennemy") && tag.Equals("Player"))
            {
                Debug.Log("hit player");
            }
            if (Owner.Equals("Player") && tag.Equals("Ennemy"))
            {
                Debug.Log("hit ennemy");
            }
        }
    }
}

