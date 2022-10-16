using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;

public class Defend : Node
{
    private readonly Animator _animator;
    public Defend(Animator animator)
    {
        _animator = animator;
    }

    public override NodeState Evaluate()
    {
        state = NodeState.RUNNING;
        return state;
    }
}
