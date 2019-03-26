using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;


public class Stick : MonoBehaviour
{



    private int timer = 0;
 




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

        }



        this.GetComponent<AudioSource>().Play();
        this.GetComponent<ConstantForce>().enabled = true;
        timer = 3;


    }





}
