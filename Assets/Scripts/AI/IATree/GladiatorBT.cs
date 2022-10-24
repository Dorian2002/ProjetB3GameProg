using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using PlayerScripts;
using UnityEngine;
using Tree =BehaviorTree.Tree;
using UnityEngine.AI;

public class GladiatorBT : Tree
{
    [SerializeField] private Equipment equipment;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform hands;
    [SerializeField] private static float speed=3f;
    [SerializeField] private static float attackRange=3f;
    [SerializeField] private static float walkRadius=20f;

    protected override Node SetUpTree()
    {
        SetUpAI();
        agent.speed=speed;
        Node root=new Selector(new List<Node>
        {
            new Sequence(new List<Node>
            {
                new CheckForPlayerRange(transform),
                new Attack(animator,transform),
            }),
            new Sequence(new List<Node>
            {
                new SearchForPlayer(transform,agent),
                new GoToPlayer(transform,agent),
            }),
            new TaskPatrol(transform, agent),
        });
        return root;
    }

    void SetUpAI()
    {
        EquipEnemy();
        animator=equipment.GetComponent<Animator>();
        Hp=100;
    }

    public static float GetAttackRange()
    {
        return attackRange;
    }

    public static float GetWalkRadius()
    {
        return walkRadius;
    }
    
    private void EquipEnemy()
    {
        try
        {
            Instantiate(Resources.Load("Prefabs/Glaive&Shield"), hands);
            equipment=hands.gameObject.GetComponentInChildren<Equipment>();
            equipment.Owner=tag;
        }catch{}
    }
}
