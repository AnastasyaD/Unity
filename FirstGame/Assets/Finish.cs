using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject finish;

    private void OnTriggerEnter(Collider col) {
    
    if ( col.tag == "Player")
    {
    finish.SetActive(true);
    }
    }
}

