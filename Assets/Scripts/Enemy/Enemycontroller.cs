using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Crowd.Enemy
{
    public class Enemycontroller : MonoBehaviour
    {
        [SerializeField] private EnemySettings _enemySettings;
        NavMeshAgent _agent;
        GameObject[] _crowds;
        

        private void Start()
        {
            _crowds = GameObject.FindGameObjectsWithTag("Crowd");

            _agent = GetComponent<NavMeshAgent>();
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, _enemySettings.LookRadius);

        }

        private void Update()
        {
            for (int i = 0; i < _crowds.Length; i++)
            {
                float distance = Vector3.Distance(transform.position,_crowds[i].transform.position);
                if (distance <= _enemySettings.LookRadius)
                {
                    _agent.SetDestination(_crowds[i].transform.position);
                    //break;
                    
                    //_agent.nextPosition = _crowds[i].transform.position;

                }


            }
            
        }
    }
}