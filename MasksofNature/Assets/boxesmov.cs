using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class boxesmov : MonoBehaviour
{
       
    private void OnCollisionEnter2D(Collision2D other)
    {
        var box = GameObject.Find("box");
        box.GetComponent<Rigidbody2D>().constraints = ~RigidbodyConstraints2D.FreezePosition;
    }
    
}
