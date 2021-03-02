using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crowd.Player
{

    [CreateAssetMenu(menuName ="Crowd/Player/PlayerSettings")]
    public class PlayerMovmentSettings : ScriptableObject
    {
        [SerializeField] public float _horizontal;
        [SerializeField] public float _vertical;
        [SerializeField] public float _horizontalSpeed;
        [SerializeField] public float _verticalSpeed;



    }
}