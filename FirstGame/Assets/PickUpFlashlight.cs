using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlashlight : MonoBehaviour
{
    public GameObject Flashlight;
    public GameObject FlashlightPlayer;
    public GameObject trigger;
    public GameObject E;

private void OnTriggerStay(Collider other) {
    E.SetActive(true);
    if(Input.GetKeyDown(KeyCode.E))
    {
        Flashlight.SetActive (false); 
        FlashlightPlayer.SetActive (true); 
        trigger.SetActive (false); 
        E.SetActive (false);
    }
}
private void OnTriggerExit(Collider other) {
    E.SetActive (false);
}
}
