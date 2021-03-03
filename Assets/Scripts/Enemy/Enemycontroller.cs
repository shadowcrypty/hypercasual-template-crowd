using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Crowd.Enemy
{
    public class Enemycontroller : MonoBehaviour
    {
        //List<T> ts = new List<T>;
        [SerializeField] private EnemySettings _enemySettings;
        NavMeshAgent _agent;
        GameObject[] _crowds;
        

        private void Start()
        {
            //ts.Sort()
            _crowds = GameObject.FindGameObjectsWithTag("Crowd");

            _agent = GetComponent<NavMeshAgent>();
            StartCoroutine(chase());
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, _enemySettings.LookRadius);

        }

        public IEnumerator chase()
        {
            for (int i = 0; i < _crowds.Length; i++)
            {
                Debug.Log("Start");
                _crowds = GameObject.FindGameObjectsWithTag("Crowd");
                float distance = Vector3.Distance(transform.position, _crowds[i].transform.position);
                if (distance <= _enemySettings.LookRadius)
                {
                    _agent.SetDestination(_crowds[i].transform.position);
                    Debug.Log(_crowds[i]);
                    

                    break;
                    //yield return null;
                }
                //

            }
            yield return new WaitForSeconds(3f);

            Debug.Log("restarted");
            StartCoroutine(chase());
           


        }
        private void Update()
        {
           

        }
    }
}