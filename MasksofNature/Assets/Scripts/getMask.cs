using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMask : MonoBehaviour
{
    public bool hasMask = false;
    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")/* && !other.isTrigger*/){
            hasMask = true;
        }
    }
}
