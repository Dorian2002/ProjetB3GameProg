using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using PlayerScripts;
using UnityEngine;
using Tree =BehaviorTree.Tree;
using UnityEngine.AI;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class GladiatorBT : Tree
{
    [SerializeField] private Equipment equipment;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform hands;
    [SerializeField] private static float speed=3f;
    [SerializeField] private static float attackRange=1.8f;
    [SerializeField] private static float walkRadius=12f;
    public override EntityStats _stats { get; set; }
    public override Image healthBar { get; set; }
    public override Transform player { get; set; }

    protected override Node SetUpTree()
    {
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

    void Start()
    {
        base.Start();
        player = GameManager.GM.player.transform;
    }
    
    public static float GetAttackRange()
    {
        return attackRange;
    }

    public static float GetWalkRadius()
    {
        return walkRadius;
    }
    
    private void EquipEnnemy()
    {
        try
        {
            Instantiate(Resources.Load("Prefabs/Glaive&Shield"), hands);
            equipment=hands.gameObject.GetComponentInChildren<Equipment>();
            equipment.OwnerStats = _stats;
        }catch{}
        animator=equipment.GetComponent<Animator>();
        agent.speed=speed;
    }

    public void SetStat(EntityStats stats)
    {
        _stats = stats;
        EquipEnnemy();
    }
    public EntityStats GetStats()
    {
        return _stats;
    }

    private void OnDestroy()
    {
        if (_stats.GetHp() <= 0)
        {
            var xp = Instantiate(Resources.Load("Prefabs/xp")as GameObject);
            xp.transform.position = new Vector3(transform.position.x, xp.transform.position.y, transform.position.z);
            GameManager.GM.UpdateWave(this);
        }
    }
}
