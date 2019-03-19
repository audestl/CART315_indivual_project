using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChange : MonoBehaviour
{


  //  public GameObject rb;
    Color[] color = new Color[2];
    int index = 0;
    private int timer = 0;


    void Start()
    {
        this.GetComponent<ColorChange>().enabled = true;
        color[0] = Color.red;
        color[1] = Color.green;

        this.GetComponent<Renderer>().material.color = color[index];
    
    }

    void FixedUpdate()
    {

        if (timer == 0)
        {
            this.GetComponent<ConstantForce>().enabled = false;
        }
        else
        {
            //Debug.Log(timer);
            timer--;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (timer == 0) {
            if (index < 1)
                index++;
            else
                index = 0;
            this.GetComponent<Renderer>().material.color = color[index];

            if (index == 1)             
                Bumper.increaseNum();
            else
                Bumper.decreaseNum();
                        }
        this.GetComponent<ConstantForce>().enabled = true;
        timer = 3;

    }

  




}
