using System;
using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    class PlayerStuff : MonoBehaviour
    {
        [SerializeField] private GameObject UI;
        [SerializeField] private GameObject subMenu;
        private Equipment Equipment;
        private List<Dropdown.OptionData> Equipments;
        [SerializeField] private Dropdown EquipmentList;
        [SerializeField] private List<Dropdown.OptionData> Capacities1;
        [SerializeField] private List<Dropdown.OptionData> Capacities2;
        [SerializeField] private List<Dropdown.OptionData> Capacities3;
        [SerializeField] private Dropdown Capacity1;
        [SerializeField] private Dropdown Capacity2;
        [SerializeField] private Dropdown Capacity3;
        
        public void ChangeEquipment()
        {
            GameManager.GM.Equipment = EquipmentList.captionText.text;
            Equipment = GameObject.Find(EquipmentList.captionText.text).GetComponent<Equipment>();
            GetCapacities();
        }

        private void Start()
        {
            GetEquipments();
            GetCapacities();
        }

        public void DisplayOptions()
        {
            if (UI.activeSelf)
            {
                UI.SetActive(false);
            }
            else
            {
                subMenu.gameObject.SetActive(false);
                UI.SetActive(true);
            }
        }

        private void GetCapacities()
        {
            if (GameManager.GM.Equipment != "Hand")
            {
                List<Dropdown.OptionData> Capacities1 = Equipment.Capacities1;
                List<Dropdown.OptionData> Capacities2 = Equipment.Capacities2;
                List<Dropdown.OptionData> Capacities3 = Equipment.Capacities3;

                Capacity1.options = new List<Dropdown.OptionData>(Equipment.Capacities1);
                Capacity2.options = new List<Dropdown.OptionData>(Equipment.Capacities2);
                Capacity3.options = new List<Dropdown.OptionData>(Equipment.Capacities3);
            }
        }

        private void GetEquipments()
        {
            List<Dropdown.OptionData> allEquipments = new List<Dropdown.OptionData>()
            {
                new Dropdown.OptionData("Hand"),
                new Dropdown.OptionData("Glaive"),
                new Dropdown.OptionData("Spear"),
                new Dropdown.OptionData("Glaive&Shield"),
            };
            Equipments = new List<Dropdown.OptionData>(allEquipments);
            
            EquipmentList.options = Equipments;
        }
    }
}

