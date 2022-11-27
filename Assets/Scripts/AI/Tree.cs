using System;
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BehaviorTree
{
    public abstract class Tree : MonoBehaviour
    {
        private Node _root = null;
        public abstract Image healthBar { get; set; }
        public abstract EntityStats _stats { get; set; }
        public abstract Transform player { get; set; }

        public void Start()
        {
            healthBar = GetComponentInChildren<Image>();
            _root = SetUpTree();
        }

        private void Update()
        {
            if (_root != null)
                _root.Evaluate();
            healthBar.fillAmount = (float)_stats.GetHp() / _stats.GetHpMax();
            //healthBar.rectTransform.LookAt(player);
        }
        
        protected abstract Node SetUpTree();
    }
}

