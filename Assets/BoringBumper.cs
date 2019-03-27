using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public DoorOpening theDoor;


private int timer = 0;




void Start()
{


}

// Update is called once per frame
void FixedUpdate()
{
    if (timer == 0)
    {
        this.GetComponent<ConstantForce>().enabled = false;

     

    }
    else
    {
    

        timer--;
    }


}

private void OnCollisionEnter(Collision collision)
{

    if (timer == 0)
    {

     
        thescore.AddScore(5);


    }



    this.GetComponent<AudioSource>().Play();
    this.GetComponent<ConstantForce>().enabled = true;
    timer = 3;


}



  


}
