using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : MonoBehaviour
{

    Vector3 temp;
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
        if (col.gameObject.name == "Big")   //if the object you collided with is the enemy
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f); //increase the size of the ball
           
        }
    }
}
