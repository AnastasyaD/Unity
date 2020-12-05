using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject enemy;

    private void Awake() {
      spawnPoint = GameObject.FindGameObjectsWithTag("Spawn");  
    }
    private void Start() {
        for (int i=0; i<spawnPoint.Length; i++)
        {
            Instantiate(enemy, spawnPoint[i].transform.position, spawnPoint[i].transform.rotation, spawnPoint[i].transform);
        }
        
    }
}
