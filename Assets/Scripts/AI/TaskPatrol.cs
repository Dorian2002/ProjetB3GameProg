using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorTree;
using UnityEngine.AI;

public class TaskPatrol : Node
{
    private readonly Transform _transform;
    private readonly NavMeshAgent _agent;
    public TaskPatrol(Transform transform, NavMeshAgent agent)
    {
        _transform = transform;
        _agent = agent;
    }

    public override NodeState Evaluate()
    {
        if (_agent.destination == _transform.position)
        {
            Vector3 randomDirection = Random.insideUnitSphere * GladiatorBT.GetWalkRadius();
            randomDirection += _transform.position;

            NavMeshHit hit;
            NavMesh.SamplePosition(randomDirection, out hit, GladiatorBT.GetWalkRadius(), 1);
            _agent.destination = hit.position;
        }
        state = NodeState.RUNNING;
        return state;
    }
}
