using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerScripts
{
    public class Player : MonoBehaviour
    {
        public Equipment equipment;
        [SerializeField] private Transform hands;
        public Capacity[] Capacities { get; set; }
        private EntityStats stats;
        [SerializeField] private Image healthbar;
        [SerializeField] private GameObject LvlUpMenu;

        void Start()
        {
            GameManager.GM.player = this;
            stats = new EntityStats("Player");
            EquipPlayer();
            equipment.anim = equipment.GetComponent<Animator>();
        }

        private void OnDestroy()
        {
            GameManager.GM.GameOver();
        }

        void Update()
        {
            if (!GameManager.GM.menuing)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0)) //Right Click
                {
                    equipment.anim.SetBool(equipment.Name + "_Attack1", true);
                }
                if (Input.GetKeyUp(KeyCode.Mouse0)) //Right Click
                {
                    equipment.anim.SetBool(equipment.Name + "_Attack1", false);
                }
                if (Input.GetKeyDown(KeyCode.Mouse1)) // Left Click
                {
                    equipment.anim.SetBool(equipment.Name + "_Attack2", true);
                }
                if (Input.GetKeyUp(KeyCode.Mouse1)) //Left Click
                {
                    equipment.anim.SetBool(equipment.Name + "_Attack2", false);
                }
                if (Input.GetKeyDown(GameManager.GM.capacity1))
                {
                    equipment.anim.SetBool(equipment.Name + "_" + GameManager.GM.Capacity1Name, true);
                }
                if (Input.GetKeyUp(GameManager.GM.capacity1))
                {
                    equipment.anim.SetBool(equipment.Name + "_" + GameManager.GM.Capacity1Name, false);
                }
                if (Input.GetKeyDown(GameManager.GM.capacity2))
                {
                    equipment.anim.SetBool(equipment.Name + "_" + GameManager.GM.Capacity2Name, true);
                }
                if (Input.GetKeyUp(GameManager.GM.capacity2))
                {
                    equipment.anim.SetBool(equipment.Name + "_" + GameManager.GM.Capacity2Name, false);
                }
                if (Input.GetKeyDown(GameManager.GM.capacity3))
                {
                    equipment.anim.SetBool(equipment.Name + "_" + GameManager.GM.Capacity3Name, true);
                }
                if (Input.GetKeyUp(GameManager.GM.capacity3))
                {
                    equipment.anim.SetBool(equipment.Name + "_" + GameManager.GM.Capacity3Name, false);
                }
            }

            float filler = (float)stats.GetHp() / stats.GetHpMax();
            healthbar.fillAmount = filler;
        }

        private void EquipPlayer()
        {
            try
            {
                Instantiate(Resources.Load("Prefabs/"+ GameManager.GM.Equipment), hands);
                equipment = hands.gameObject.GetComponentInChildren<Equipment>();
                equipment.OwnerStats = stats;
            }catch{}
        }

        public EntityStats GetStats()
        {
            return stats;
        }

        public void LevelUp()
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            GameManager.GM.menuing = true;
            
            LvlUpMenu.SetActive(true);
        }
        public void UpgradeDamages()
        {
            stats.UpgradeDamages();
            LvlUpMenu.SetActive(false);
            
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            GameManager.GM.menuing = false;
            Time.timeScale = 1;
        }
        public void UpgradeMaxHp()
        {
            stats.UpgradeMaxHp();
            LvlUpMenu.SetActive(false);
            
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            GameManager.GM.menuing = false;
            Time.timeScale = 1;
        }
    }
}
