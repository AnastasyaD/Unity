using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    private void OnCollisionStay(Collision other) {
                if (Input.GetKeyDown(KeyCode.E))
         {
            transform.localEulerAngles = new Vector3(0, 270, 0);
            
         }
    } 
}
