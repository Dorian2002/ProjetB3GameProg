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
        public abstract EntityStats OwnerStats { get; set; }
        public abstract Animator anim { get; set; }

        private void OnTriggerEnter(Collider other)
        {
            if (other == null)
                return;
            tag = other.tag;
            if (OwnerStats.GetOwner().Equals("Ennemy") && tag.Equals("Player"))
            {
                EntityStats stats = other.GetComponent<EntityStats>();
                stats.Damage(OwnerStats.GetDamage());
            }
            if (OwnerStats.GetOwner().Equals("Player") && tag.Equals("Ennemy"))
            {
                Debug.Log("lo");
                Debug.Log(other.gameObject);
                EntityStats stats = other.gameObject.GetComponent<EntityStats>();
                stats.Damage(OwnerStats.GetDamage());
            }
        }
    }
}

