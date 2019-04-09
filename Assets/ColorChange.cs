using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChange : MonoBehaviour
{


  //  public GameObject rb;
    Material[] color = new Material[2];
    int index = 0;
    private int timer = 0;

   // private Color rouge = new Color(0.94F,0.70F,1F);
    public Material rouge;
    public Material vert;


    void Start()
    {   
        this.GetComponent<ColorChange>().enabled = true;
        color[0] = rouge;
        color[1] = vert;

       // this.GetComponent<Renderer>().material.color = color[index];
    
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
    public void OnCollisionEnter(Collision collision)
    {
        if (timer == 0) {
            if (index < 1)
                index++;
            else
                index = 0;
         //   this.GetComponent<Renderer>().material.color = color[index];

            //if (index == 1)             
            //   // Bumper.increaseNum();
            //else
               //// Bumper.decreaseNum();
        }
        this.GetComponent<ConstantForce>().enabled = true;
        timer = 3;

    }

  




}
