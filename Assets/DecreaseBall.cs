using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseBall : MonoBehaviour
{

    public int counter = 0;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnCollisionEnter(Collision col)  //Unity function called when a collision is detected, and the object collided is put into the variable 'col' to be used later
    {
        if (col.gameObject.name == "Small")   //if the ball collides with bumper "small"
        {
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f); //decrease the size of the ball
            counter++;
        }
        if(counter==3)
        {
            ; 
        }
    }
}

