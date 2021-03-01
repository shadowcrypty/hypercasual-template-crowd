using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MembersPosSet : MonoBehaviour
{
    public Vector3 offset;
    public float _aci;
    public int childs;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        childs = transform.childCount;
        for (int i = 0; i < transform.childCount; i++)
        {
            //168 next stack

            if (i >= 120)
            {
                _aci = i * 45 / 6;

                offset = new Vector3(Mathf.Sin(_aci * Mathf.Deg2Rad), 0, Mathf.Cos(_aci * Mathf.Deg2Rad));
                transform.GetChild(i).position = transform.parent.position + offset * 6;


            }
            else if (i >=80)
            {
                _aci = i * 45 / 5;

                offset = new Vector3(Mathf.Sin(_aci * Mathf.Deg2Rad), 0, Mathf.Cos(_aci * Mathf.Deg2Rad));
                transform.GetChild(i).position = transform.parent.position + offset * 5;


            }
            else if (i >= 48)
            {
                _aci = i * 45 / 4;

                offset = new Vector3(Mathf.Sin(_aci * Mathf.Deg2Rad), 0, Mathf.Cos(_aci * Mathf.Deg2Rad));
                transform.GetChild(i).position = transform.parent.position + offset * 4;

            }

            else if (i >= 24)
            {
                _aci = i * 45 / 3;

                offset = new Vector3(Mathf.Sin(_aci * Mathf.Deg2Rad), 0, Mathf.Cos(_aci * Mathf.Deg2Rad));
                transform.GetChild(i).position = transform.parent.position + offset * 3;

            }
            else if (i >= 8)
            {
                //x = 2 * 1;
                _aci = i * 45 / 2;

                offset = new Vector3(Mathf.Sin(_aci * Mathf.Deg2Rad), 0, Mathf.Cos(_aci * Mathf.Deg2Rad));
                transform.GetChild(i).position = transform.parent.position + offset * 2;

            }
            
            else
            {
                _aci = i * 45;

                offset = new Vector3(Mathf.Sin(_aci * Mathf.Deg2Rad), 0, Mathf.Cos(_aci * Mathf.Deg2Rad));
                transform.GetChild(i).position = transform.parent.position + offset;
            }
            


        }
        
    }
}
