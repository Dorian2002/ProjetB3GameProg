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
            tag = other.tag;
            if (other == null || (tag != "Ennemy" && tag != "Player"))
                return;
            if (OwnerStats.GetOwner().Equals("Ennemy") && tag.Equals("Player"))
            {
                EntityStats stats = other.gameObject.GetComponentInParent<Player>().GetStats();
                stats.Damage(OwnerStats.GetDamage());
                if (stats.GetHp() <= 0)
                {
                    Destroy(other.gameObject);
                }
            }
            if (OwnerStats.GetOwner().Equals("Player") && tag.Equals("Ennemy"))
            {
                Debug.Log(other.gameObject.GetComponentInParent<GladiatorBT>());
                EntityStats stats = other.gameObject.GetComponentInParent<GladiatorBT>().GetStats();
                stats.Damage(OwnerStats.GetDamage());
                if (stats.GetHp() <= 0)
                {
                    Destroy(other.GetComponentInParent<GladiatorBT>().gameObject);
                }
            }
        }
    }
}

