using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
   
    private float _speed = 3;
    private float _turnSpeed = 90;
    private Vector3 _direction = Vector3.zero;

    private void Update()
    {
        //_rotation = Input.GetAxis("Horizontal");
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");        
    }
    private void FixedUpdate()
    {
        transform.Translate(_direction.z * Vector3.forward * _speed * Time.fixedDeltaTime);
        transform.Rotate(Vector3.up * _direction.x * _turnSpeed * Time.fixedDeltaTime);
    }
}