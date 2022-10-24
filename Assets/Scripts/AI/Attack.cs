using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;

public class Attack : Node
{
    private readonly Animator _animator;
    private readonly Transform _self;
    public Attack(Animator animator, Transform self)
    {
        _animator = animator;
        _self = self;
    }

    public override NodeState Evaluate()
    {
        var target = (Transform)GetData("target");
        _self.LookAt(target.position, Vector3.one);
        _animator.SetBool("Glaive&Shield_Attack1", true);
        state = NodeState.SUCCESS;
        return state;
    }
}
