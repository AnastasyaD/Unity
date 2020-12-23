using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRay : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private Transform _player;
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Animator myAnimator;
    private float distance;
    private float invoke_delay = 4f;
    private RaycastHit hit;
    private float _startOffset = 1.5f;

    private bool isPatrol = true;    
    private int m_CurrentWaypointIndex = 0;
   

    private void Awake(){
       _player = GameObject.FindGameObjectWithTag("Player").transform; 
       
    }
    private void Start() 
    {
        navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
        navMeshAgent.speed = Random.Range(0.5f, 2f);
    }

    private void FixedUpdate() 
    {
        var color = Color.red;
        RaycastHit hit;
        
        var startRaycastPosition = CalculateOffset(transform.position);
        var directionToPlayer = CalculateOffset(_player.position) - startRaycastPosition;

        var rayCast = Physics.Raycast(startRaycastPosition, directionToPlayer, out hit, directionToPlayer.magnitude, _mask);
        
        if (rayCast)
        {
            
               if (hit.collider.gameObject.CompareTag("Player"))
            {
                color = Color.green;
                FollowTarget();
             }
             else
            {
                Invoke("Comeback", invoke_delay);
            }

        }

        Debug.DrawRay(startRaycastPosition, directionToPlayer, color);
    }

    public void SetWaypoint(Transform[] wayPoints)
    {
        waypoints = wayPoints;
    }
    private Vector3 CalculateOffset(Vector3 position)
    {
        position.y += _startOffset;
        return position;
    }

    private void Comeback()
    {
        if (isPatrol == true && navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {            
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
        }
        else if (!isPatrol)
        {
            Wait();
            Invoke(nameof(Go), 2f);
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            isPatrol = true;
        }
    }
    private void FollowTarget()
    {
        distance = Vector3.Distance(transform.position, _player.position);
        if (distance < 10 && distance > 1.5) {
        isPatrol = false;
        navMeshAgent.SetDestination(_player.position);
        myAnimator.Play ("Z_Run");
        }

        if (distance <= 1.5) {
        isPatrol = false;
        navMeshAgent.SetDestination(_player.position);
        myAnimator.Play ("Z_Attack");
        }
        
    }

    private void Wait()
    {
        navMeshAgent.isStopped = true;
    }

    private void Go()
    {
        navMeshAgent.isStopped = false;
    }

}
