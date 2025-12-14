using System;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float distanceUntilFollow;
    [SerializeField] private float speed;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (distanceUntilFollow <= Vector3.Distance(target.position, transform.position))
        {
            _agent.SetDestination(target.position);
        }

        _agent.speed = Vector3.Distance(target.position, transform.position) * 0.25f * speed;
    }
}
