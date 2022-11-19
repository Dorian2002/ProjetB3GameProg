using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerScripts
{
    public class Player : MonoBehaviour
    {
        public Equipment equipment;
        [SerializeField] private Transform hands;
        public Capacity[] Capacities { get; set; }
        private EntityStats stats;

        void Start()
        {
            stats = GetComponent<EntityStats>();
            EquipPlayer();
            equipment.anim = equipment.GetComponent<Animator>();
        }

        void Update()
        {
            if (stats.GetHp() <= 0)
            {
                Destroy(this);
                GameManager.GM.GameOver();
            }
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
        }

        private void EquipPlayer()
        {
            try
            {
                Instantiate(Resources.Load("Prefabs/"+ GameManager.GM.Equipment), hands);
                equipment = hands.gameObject.GetComponentInChildren<Equipment>();
                equipment.OwnerStats = GetComponent<EntityStats>();
            }catch{}
        }

        public void Damage(int damage)
        {
            stats.Damage(damage);
        }
    }
}
