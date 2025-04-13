using UnityEngine;
using UnityEngine.AI;

public class Pathfinder : MonoBehaviour
{
    private NavMeshAgent m_agent;

    [SerializeField] private Transform target;

    private void Start()
    {
        m_agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
       m_agent.destination = target.position;
    }
}
