using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
   
    private float _speed = 3;
    private float _turnSpeed = 15;
    private Vector3 _direction = Vector3.zero;

    private void Update()
    {
        _direction.x = -Input.GetAxis("Horizontal");
        _direction.z = -Input.GetAxis("Vertical");
        
        transform.position += _direction * _speed * Time.deltaTime;
        
    }
}