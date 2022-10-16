using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorTree;

public class SearchForPlayer : Node
{
    private static int PlayerLayerMask = 1 << 7;
    private readonly Transform _transform;

    public SearchForPlayer(Transform transform)
    {
        _transform = transform;
    }

    public override NodeState Evaluate()
    {
        var target = GetData("target");
        if (target == null)
        {
            var hitColliders = new Collider[0];
            hitColliders = Physics.OverlapSphere(
                _transform.position, GladiatorBT.GetWalkRadius(), PlayerLayerMask);
            if (hitColliders.Length > 0)
            {
                foreach (var col in hitColliders)
                {
                    parent.parent.SetData("target", col.transform);
                    state = NodeState.SUCCESS;
                    return state;
                } 
            }
            state = NodeState.FAILURE;
            return state;
        }
        state = NodeState.SUCCESS;
        return state;
    }
}
