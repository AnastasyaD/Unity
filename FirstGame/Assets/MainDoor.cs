using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : MonoBehaviour
{
    
    //public GameObject keyPlayer;
    public GameObject E;
    [SerializeField] private int keyID;

    private void OnCollisionStay(Collision collision) {
        E.SetActive(true);
           //if (Input.GetKeyDown(KeyCode.E)){
     if (collision.gameObject.CompareTag("Player"))          
    if (collision.gameObject.GetComponent<MainPlayer>().HaveKey(keyID))
             {
            transform.localEulerAngles = new Vector3(0, 90, 0);
            E.SetActive (false);
            
           }
                                             
         //}
    } 
    private void OnTriggerExit(Collider other) {
    E.SetActive (false);
}
}

