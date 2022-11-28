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
        
        Vector3 dir = target.position - _self.position;
        dir.y = 0; // keep the direction strictly horizontal
        Quaternion rot = Quaternion.LookRotation(dir);
        // slerp to the desired rotation over time
        _self.rotation = Quaternion.Slerp(_self.rotation, rot, 10 * Time.deltaTime);
        
        _animator.Play("Glaive&Shield_Attack1");
        state = NodeState.SUCCESS;
        return state;
    }
}
