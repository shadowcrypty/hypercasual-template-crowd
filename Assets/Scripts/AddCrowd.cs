using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crowd.Member
{


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
                Debug.Log(enemy.name);
                transform.SetParent(enemy);

                this.tag = "Enemy";

            }
        }

    }
}