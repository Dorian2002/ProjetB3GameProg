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
        [SerializeField] private Dropdown Capacity1;
        [SerializeField] private Dropdown Capacity2;
        [SerializeField] private Dropdown Capacity3;
        
        public void ChangeEquipment()
        {
            GameManager.GM.Equipment = EquipmentList.captionText.text;
            Equipment = GameObject.Find(EquipmentList.captionText.text).GetComponent<Equipment>();
            GetCapacities();
        }
        
        public void ChangeCapacities()
        {
            GameManager.GM.Capacity1Name = Capacity1.captionText.text;
            GameManager.GM.Capacity2Name = Capacity2.captionText.text;
            GameManager.GM.Capacity3Name = Capacity3.captionText.text;
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
                Capacity1.options = new List<Dropdown.OptionData>(Equipment.Capacities1);
                Capacity2.options = new List<Dropdown.OptionData>(Equipment.Capacities2);
                Capacity3.options = new List<Dropdown.OptionData>(Equipment.Capacities3);
            }
            ChangeCapacities();
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
            ChangeEquipment();
        }
    }
}

