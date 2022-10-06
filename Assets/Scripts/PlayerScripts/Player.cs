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
        private Equipment EquipmentLeft;
        private Transform RightHand;
        private Transform LeftHand;
        private int Level;
        private int Exp;

        private void Start()
        {
            //EquipmentRight = Resources.Load("Prefabs/Glaive") as Equipment;
            EquipPlayer();
        }


        private void EquipPlayer()
        {
            try
            {
                Instantiate(EquipmentRight,RightHand);
            }catch{}
            try
            {
                Instantiate(EquipmentLeft, LeftHand.transform);
            }catch{}
        }
    }
}
