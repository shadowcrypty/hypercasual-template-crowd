﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crowd.Player
{


    public class PlayerMovment : MonoBehaviour
    {
        [SerializeField] private PlayerMovmentSettings _playerMovmentSettings;


        void inputValues()
        {
            _playerMovmentSettings._horizontal=Input.GetAxis("Horizontal");
            _playerMovmentSettings._vertical = Input.GetAxis("Vertical");

        }
        private void Update()
        {
            inputValues();
            transform.Translate(Vector3.right * _playerMovmentSettings._horizontal*_playerMovmentSettings._horizontalSpeed);
            transform.Translate(Vector3.forward * _playerMovmentSettings._vertical*_playerMovmentSettings._verticalSpeed);
        }
    }
}