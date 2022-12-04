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
        public abstract EntityStats _stats { get; set; }
        public abstract Transform player { get; set; }

        public void Start()
        {
            _root = SetUpTree();
        }

        public void Update()
        {
            if (_root != null)
                _root.Evaluate();
        }
        
        protected abstract Node SetUpTree();
    }
}

