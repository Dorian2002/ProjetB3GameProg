using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;
using UnityEngine.AI;

public class GoToPlayer : Node
{
    private readonly Transform _transform;
    private readonly NavMeshAgent _agent;
    public GoToPlayer(Transform transform, NavMeshAgent agent)
    {
        _transform = transform;
        _agent = agent;
    }

    public override NodeState Evaluate()
    {
        var target = (Transform)GetData("target");
        
        if (Vector3.Distance(target.position,_transform.position) <= GladiatorBT.GetAttackRange())
        {
            _agent.destination = _agent.transform.position;
            state = NodeState.SUCCESS;
            return state;
        }
        else
        {
            _agent.destination = target.position;
        }

        state = NodeState.RUNNING;
        return state;
    }
}
