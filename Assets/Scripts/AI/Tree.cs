using System;
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public abstract class Tree : MonoBehaviour
    {
        
        private Node _root = null;
        protected int Hp;

        protected void Start()
        {
            _root = SetUpTree();
        }

        private void Update()
        {
            if (Hp <= 0)
            {
                Destroy(gameObject);
            }
            if (_root != null)
                _root.Evaluate();
        }

        protected abstract Node SetUpTree();
    }
}

