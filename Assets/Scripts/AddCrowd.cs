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
        public Vector3 cordinate;

        
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag=="Player" && this.tag != "Player")
            {
                transform.SetParent(_member.transform);
                
                //Debug.Log(_aci);
                //cordinate =new Vector3(Mathf.Sin(_aci*Mathf.Deg2Rad),1.5f,Mathf.Cos(_aci*Mathf.Deg2Rad))+transform.parent.parent.position;
                
                transform.position = cordinate;
                
                this.tag = "Player";
            }
        }

    }
}