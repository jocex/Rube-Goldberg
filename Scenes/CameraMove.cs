using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public BoxCollider2D bc;
    public Vector3 myVector;
    public Transform cam1;

    void Awake(){
       bc = GetComponent<BoxCollider2D>();
       bc.isTrigger = true;
   }

    void OnTriggerEnter2D(Collider2D collision){
   if (collision.CompareTag("Player")){ 
     cam1.transform.position = cam1.position+myVector;
   }
   
    Debug.Log("A collision happened");

   } 
}

