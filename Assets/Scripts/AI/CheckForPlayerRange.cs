using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;


public class CheckForPlayerRange : Node
{
    private readonly Transform _transform;
    public CheckForPlayerRange(Transform transform)
    {
        _transform = transform;
    }
    public override NodeState Evaluate()
    {
        Transform target = (Transform)GetData("target");
        if (!target)
        {
            state = NodeState.FAILURE;
            return state;
        }
        
        if (Vector3.Distance(target.position, _transform.position) <= GladiatorBT.GetAttackRange())
        {
            state = NodeState.SUCCESS;
            return state;
        }

        state = NodeState.FAILURE;
        return state;
    }
}