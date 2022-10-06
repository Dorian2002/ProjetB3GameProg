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
        public Equipment EquipmentRight;
        public Equipment EquipmentLeft;
        [SerializeField] private Transform RightHand;
        [SerializeField] private Transform LeftHand;
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
                anim.CrossFade(EquipmentRight.Name,1);
            }
            if (Input.GetKeyDown(KeyCode.Mouse1)) // Left Click
            {
                anim.CrossFade(EquipmentLeft.Name,1);
            }
        }

        private void EquipPlayer()
        {
            try
            {
                Instantiate(Resources.Load("Prefabs/"+ GameManager.GM.EquipmentRight), RightHand);
                EquipmentRight = RightHand.gameObject.GetComponentInChildren<Equipment>();
            }catch{}
            try
            {
                Instantiate(Resources.Load("Prefabs/"+ GameManager.GM.EquipmentLeft), LeftHand);
                EquipmentLeft = LeftHand.gameObject.GetComponentInChildren<Equipment>();
            }catch{}
        }
    }
}
