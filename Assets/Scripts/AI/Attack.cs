using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;

public class Attack : Node
{
    private readonly Animator _animator;
    public Attack(Animator animator)
    {
        _animator = animator;
    }

    public override NodeState Evaluate()
    {
        _animator.SetBool("Glaive&Shield_Attack1", true);
        state = NodeState.SUCCESS;
        return state;
    }
}
