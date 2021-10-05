using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceStart : MonoBehaviour
{  public GameObject objectToDeactivate;

void Update(){
    if(Input.GetKeyDown(KeyCode.Space)){
        objectToDeactivate.SetActive(false);
    }

}
}
    
