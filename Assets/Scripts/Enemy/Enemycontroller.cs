using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Crowd.Member;
using System.Linq;

namespace Crowd.Enemy
{
    public class Enemycontroller : MonoBehaviour
    {
        //List<T> ts = new List<T>;
        public List<LCrowd> cList = new List<LCrowd>();
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
            _crowds = GameObject.FindGameObjectsWithTag("Crowd");
            for (int i = 0; i < _crowds.Length; i++)
            {
                LCrowd _lCrowd=new LCrowd(gameObject,_crowds[i]);
                //_lCrowd.crowd = _crowds[i];

                cList.Add(_lCrowd);

            }
            float min = cList.Min(item => item.distance);
            //var nearest = cList.Where(item => item.distance == min);
            //Debug.Log(nearest);
            foreach (var item in cList)
            {
                if (item.distance == min)
                {
                    _agent.SetDestination(item.cVector);
                    break;
                   
                }
            }
            
            yield return _agent.speed == 0;
            cList.Clear();

            Debug.Log("restarted");
            StartCoroutine(chase());
           


        }
        private void Update()
        {
            

        }
    }
}