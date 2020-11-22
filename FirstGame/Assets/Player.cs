using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    
      private float _speed = 15;
    private Vector3 _direction = Vector3.zero;

    private void Update()
    {
        _direction.x = -Input.GetAxis("Horizontal");
        _direction.z = -Input.GetAxis("Vertical");

        transform.position += _direction * Time.deltaTime;
    }
}