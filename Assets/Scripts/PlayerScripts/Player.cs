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
            anim = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) //Right Click
            {
                anim.CrossFade(Equipment.Name,1);
            }
            if (Input.GetKeyDown(KeyCode.Mouse1)) // Left Click
            {
                anim.CrossFade(Equipment.Name,1);
            }
            if (Input.GetKeyDown(GameManager.GM.capacity1))
            {
               //anim.CrossFade(EquipmentRight.Name,1);
            }
            if (Input.GetKeyDown(GameManager.GM.capacity2))
            {
                //anim.CrossFade(EquipmentLeft.Name,1);
            }
            if (Input.GetKeyDown(GameManager.GM.capacity3))
            {
                //anim.CrossFade(EquipmentLeft.Name,1);
            }
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
