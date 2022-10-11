using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerScripts
{
    public class Player : MonoBehaviour
    {
        public int Hp { get; set; }
        public int MovementSpeed { get; set; }
        public int AttackSpeed { get; set; }
        public Equipment Equipment;
        [SerializeField] private Transform Hands;
        public Capacity[] Capacities { get; set; }
        private int Level;
        private int Exp;
        private Animator anim;

        private void Start()
        {
            EquipPlayer();
            anim = Equipment.GetComponent<Animator>();
        }

        private void Update()
        {
            if (!GameManager.GM.menuing)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0)) //Right Click
                {
                    anim.SetBool(Equipment.Name + "_Attack1", true);
                }
                if (Input.GetKeyUp(KeyCode.Mouse0)) //Right Click
                {
                    anim.SetBool(Equipment.Name + "_Attack1", false);
                }
                if (Input.GetKeyDown(KeyCode.Mouse1)) // Left Click
                {
                    anim.SetBool(Equipment.Name + "_Attack2", true);
                }
                if (Input.GetKeyUp(KeyCode.Mouse1)) //Left Click
                {
                    anim.SetBool(Equipment.Name + "_Attack2", false);
                }
                if (Input.GetKeyDown(GameManager.GM.capacity1))
                {
                    anim.SetBool(Equipment.Name + "_" + GameManager.GM.Capacity1Name, true);
                }
                if (Input.GetKeyUp(GameManager.GM.capacity1))
                {
                    anim.SetBool(Equipment.Name + "_" + GameManager.GM.Capacity1Name, false);
                }
                if (Input.GetKeyDown(GameManager.GM.capacity2))
                {
                    anim.SetBool(Equipment.Name + "_" + GameManager.GM.Capacity2Name, true);
                }
                if (Input.GetKeyUp(GameManager.GM.capacity2))
                {
                    anim.SetBool(Equipment.Name + "_" + GameManager.GM.Capacity2Name, false);
                }
                if (Input.GetKeyDown(GameManager.GM.capacity3))
                {
                    anim.SetBool(Equipment.Name + "_" + GameManager.GM.Capacity3Name, false);
                }
            }
        }
        public void ResetAnimation()
        {
            anim.SetBool("Glaive&Shield_Attack1", false);
            anim.SetBool("Glaive&Shield_Attack2", false);
        }

        private void EquipPlayer()
        {
            try
            {
                Instantiate(Resources.Load("Prefabs/"+ GameManager.GM.Equipment), Hands);
                Equipment = Hands.gameObject.GetComponentInChildren<Equipment>();
            }catch{}
        }
    }
}
