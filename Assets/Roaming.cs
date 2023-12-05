using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Roaming : MonoBehaviour
{
    //[SerializeField] Transform playerPos;
    //[SerializeField] Transform[] moveSpot;
    //public AIRoamStats _NormalRoamStats;
    //NavMeshAgent _Agent;
    //int randomSpot;
    //private void Awake()
    //{
    //    _Agent = GetComponent<NavMeshAgent>();
    //}
    //private void Start()
    //{
    //    randomSpot = Random.Range(0, moveSpot.Length);
    //    StartCoroutine(patrolToOther());
    //}
    //private void Update()
    //{
    //    //Patrol();
    //    PlayerSpot();
    //    float distance = Vector3.Distance(transform.position, moveSpot[randomSpot].position);
    //    //distance = Vector3.Distance(_Agent.transform.position, moveSpot[randomSpot].position);
    //}

    ////void Patrol()
    ////{
    ////    _Agent.SetDestination(moveSpot[randomSpot].position);
    ////    float distance = Vector3.Distance(_Agent.transform.position, moveSpot[randomSpot].position);
    ////    Debug.Log(distance);
    ////    if (distance <= 1f)
    ////    {

    ////        randomSpot = Random.Range(0, moveSpot.Length);

    ////    }
    ////    else
    ////    {

    ////    }
    ////}

    //void PlayerSpot()
    //{
    //    RaycastHit hit;
    //    float enemyAngle = Vector3.Angle(transform.forward, playerPos.position);
    //    if (enemyAngle < _NormalRoamStats.fov)
    //    {
    //        if (Physics.Raycast(transform.position, playerPos.position, out hit, _NormalRoamStats.angle))
    //        {
    //            TargetPlayer();
    //            _Agent.SetDestination(playerPos.position);
    //            Debug.Log("Player inSight");
    //        }
    //        else
    //        {
    //            _Agent.SetDestination(moveSpot[randomSpot].position);
    //        }
    //    }


    //}

    //void TargetPlayer()
    //{
    //    Quaternion faceDirection = Quaternion.LookRotation(playerPos.position);
    //    transform.rotation = Quaternion.Slerp(transform.rotation, faceDirection, Time.deltaTime * 300f);
    //}
    //IEnumerator patrolToOther()
    //{
    //    bool onTheSpot = false;
    //    while (true)
    //    {
    //        float distance = Vector3.Distance(transform.position, moveSpot[randomSpot].position);
    //        _Agent.SetDestination(moveSpot[randomSpot].position);
    //        Debug.Log(distance);
    //        if (distance <= 1f)
    //        {
    //            Debug.Log("Updating Pos");
    //            yield return new WaitForSeconds(2);
    //            onTheSpot = true;
    //            randomSpot = Random.Range(0, moveSpot.Length);
    //        }
    //        yield return new WaitUntil(() => onTheSpot);
    //    }
    //}

    //IEnumerator ChasePlayer()
    //{
    //    RaycastHit hit;
    //    float enemyAngle = Vector3.Angle(transform.forward, playerPos.position);
    //    if (enemyAngle < _NormalRoamStats.fov)
    //    {
    //        if (Physics.Raycast(transform.position, playerPos.position, out hit, _NormalRoamStats.angle))
    //        {
    //            TargetPlayer();
    //            _Agent.SetDestination(playerPos.position);
    //            Debug.Log("Player inSight");
    //        }
    //        else
    //        {
    //            _Agent.SetDestination(moveSpot[randomSpot].position);
    //        }
    //    }
    //}
}
