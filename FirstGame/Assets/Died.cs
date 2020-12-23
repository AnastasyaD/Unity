using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Died : MonoBehaviour


{
    [SerializeField] private GameObject died;
    //[SerializeField] private Transform _enemy;
    //private float distance;

//private void Awake(){
    //   _enemy = GameObject.FindGameObjectWithTag("Enemy").transform; 
       
    //}
    
    // Start is called before the first frame update
    //private void Update()
   // {
    //distance = Vector3.Distance(transform.position, _enemy.position);
    
   // if (distance < 3)
    //{
   // died.SetActive(true);
    //Destroy(gameObject);
    //}
    //}


    private void OnTriggerEnter(Collider other) {
    
    if ( other.tag == "Enemy")
    {
    died.SetActive(true);
    Destroy(gameObject);
    }
    }
}
