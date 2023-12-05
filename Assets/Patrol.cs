using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Patrol : MonoBehaviour
{
    public AIRoamStats _AINormalStats;
    [SerializeField] Transform playerPos;
    [SerializeField] Transform[] patrolPos;
    NavMeshAgent _Agent;

    int random;

    public bool isPlayerDetected;
    public bool isPatrolling;
    private void Awake()
    {
        _Agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        isPatrolling = true;
        random = Random.Range(0, patrolPos.Length);
        //StartCoroutine(Patrolling());
    }
    private void Update()
    {
        PlayerDetect();
        if (!isPlayerDetected && isPatrolling)
        {
            PatrolMove();
        }
        else if (isPlayerDetected && !isPatrolling)
        {
            PlayerChase();
        }
        //patrolDistance = Vector3.Distance(transform.position, patrolPos[random].position); //FOR COROUTINE ONLY
        
    }

    void PatrolMove()
    {
        _Agent.SetDestination(patrolPos[random].position);
        float patrolDistance = Vector3.Distance(transform.position, patrolPos[random].position);
        if (patrolDistance <= 1f)
        {
            random = Random.Range(0, patrolPos.Length);
            _Agent.SetDestination(patrolPos[random].position);
        }
    }

    void PlayerChase()
    {
        TargetLock();
        _Agent.SetDestination(playerPos.position);

    }
    void TargetLock()
    {
        //distance for lookRotation to only look at the direction of calculated position and not modify other axis
        Vector3 distance = (playerPos.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(distance);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 160f * Time.deltaTime);
    }
    void PlayerDetect()
    {
        RaycastHit hit;

        Vector3 playerDist = playerPos.position - transform.position;

        float angle = Vector3.Angle(transform.forward, playerDist);
        if (angle < _AINormalStats.fov * 0.5f)
        {
            if (Physics.Raycast(transform.position, playerDist, out hit, 10f))
            {
                if (hit.collider.CompareTag("Player"))
                {
                    isPlayerDetected = true;
                    isPatrolling = false;
                    Debug.Log("Player Detected");
                }
            }
            else
            {
                isPlayerDetected = false;
                isPatrolling = true;
            }
        }
    }
    /*
    void PlayerDetect()
    {
        RaycastHit hit;
        //
        Vector3 playerDist = transform.position - playerPos.position;
        //
        float angle = Vector3.Angle(transform.forward, playerDist);
        if (angle < _AINormalStats.fov * 0.5f)
        {
            if (Physics.Raycast(transform.position, playerDist, out hit, _AINormalStats.angle))
            {
                if (hit.collider.CompareTag("Player"))
                {
                    //transform.LookAt(hit.point);
                    //_Agent.SetDestination(playerPos.position);
                    PlayerChase();
                    isPlayerDetected = true;
                    isPatrolling = false;
                    Debug.Log("Player Detected");
                }
                else
                {
                    isPlayerDetected = false;
                    isPatrolling = true;
                }
            }
        }
        
    }
    */
    //IEnumerator Patrolling()
    //{
    //    while (!isPlayerDetected)
    //    {
    //        bool onTheSpot = false;
    //        _Agent.SetDestination(patrolPos[random].position);
    //        if (patrolDistance <= 1f)
    //        {
    //            yield return new WaitForSeconds(2);
    //            random = Random.Range(0, patrolPos.Length);
    //            _Agent.SetDestination(patrolPos[random].position);
    //            onTheSpot = true;
    //        }
    //        yield return new WaitUntil(() => onTheSpot);
    //    }
    //}
}
