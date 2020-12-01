using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEOnTheDoor : MonoBehaviour
{
    public GameObject E;

private void OnTriggerStay(Collider other) {
    E.SetActive(true);
    if(Input.GetKeyDown(KeyCode.E))
    {
        E.SetActive (false);
    }
}
private void OnTriggerExit(Collider other) {
    E.SetActive (false);
}
}
