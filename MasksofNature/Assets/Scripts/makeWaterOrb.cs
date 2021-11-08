using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeWaterOrb : MonoBehaviour
{
    public GameObject waterOrb;
    public void Spawn(Vector2 position){
        Instantiate(waterOrb).transform.position = position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
