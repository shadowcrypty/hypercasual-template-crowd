using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crowd.Member
{


    public class AddCrowd : MonoBehaviour
    {
        public GameObject _member;
        public float _aci ;
        public float _offset;

        
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag=="Player" && this.tag != "Player")
            {
                transform.SetParent(_member.transform);
                _aci = _member.transform.childCount - 1;
                _aci *= 90;
                transform.position=new Vector3();
                this.tag = "Player";
            }
        }
        

    }
}