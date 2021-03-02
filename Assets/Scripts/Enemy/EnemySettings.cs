using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Crowd.Enemy
{

    [CreateAssetMenu(menuName = "Crowd/Enemy/EnemySettings")]
    public class EnemySettings : ScriptableObject
    {
        [SerializeField] private float _lookRadius=1;
        public float LookRadius { get { return _lookRadius; } }
        
    }
}