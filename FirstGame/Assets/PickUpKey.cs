using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
     public GameObject rust_key;
    public GameObject keyPlayer;
    [SerializeField] private int keyID;
    //public GameObject door;
    public GameObject trigger;
    public GameObject E;

private void OnTriggerStay(Collider other) {
    E.SetActive(true);
    if (other.CompareTag("Player"))
    if(Input.GetKeyDown(KeyCode.E))
    {
        other.GetComponent<MainPlayer>().AddKey(keyID);
        rust_key.SetActive (false); 
        keyPlayer.SetActive (true); 
        trigger.SetActive (false); 
        E.SetActive (false);
    }
}
private void OnTriggerExit(Collider other) {
    E.SetActive (false);
}
}
