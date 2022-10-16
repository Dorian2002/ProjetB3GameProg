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
        object target = GetData("target");
        if (target == null)
        {
            state = NodeState.FAILURE;
            return state;
        }

        Transform targetTransform = (Transform)target;
        if (Vector3.Distance(targetTransform.position,_transform.position) <= GladiatorBT.GetAttackRange())
        {
            state = NodeState.SUCCESS;
            return state;
        }

        state = NodeState.FAILURE;
        return state;
    }
}
