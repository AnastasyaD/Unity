using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{

    [SerializeField] private AudioSource audioSource;
    
    private void OnCollisionStay(Collision other) {
                if (Input.GetKeyDown(KeyCode.E))
         {
            transform.localEulerAngles = new Vector3(0, 270, 0);
            audioSource.Play();
         }
    } 
}
