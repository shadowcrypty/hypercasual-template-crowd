using System.Collections;
using System.Collections.Generic;
using UnityEngine;







namespace Crowd.Member
{

    public class LCrowd
    {
        public GameObject crowd;
        public GameObject enemyai;
        public float distance;
        public Vector3 cVector;
        public LCrowd(GameObject enemyai, GameObject crowd)
        {


            this.distance = Vector3.Distance(enemyai.transform.position, crowd.transform.position);
            cVector = crowd.transform.position;
        }


    }


    public class AddCrowd : MonoBehaviour
    {
        public GameObject _member;
        
        
       

        
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag=="Player" && this.tag != "Player")
            {
                transform.SetParent(_member.transform);
                this.tag = "Player";
            }
            else if(other.tag == "Enemy")
            {

                Transform enemy = other.transform.childCount == 0 ? other.transform.parent.transform : other.transform.GetChild(0);
                //Debug.Log(enemy.name);
                transform.SetParent(enemy);

                this.tag = "Enemy";

            }
        }

    }
}