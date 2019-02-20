using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    private Vector3 initialPosition;
    public GameObject theball;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = theball.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("game over");
        if(collider.gameObject ==theball)
        {
            theball.transform.position = initialPosition;
        }

    }
}

