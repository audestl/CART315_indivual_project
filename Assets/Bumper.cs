using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bumper : MonoBehaviour
{
    public Score thescore;
    public DoorOpening theDoor;

    private static int num;
    private int timer = 0;
    private bool activeColorChange = true;
    Color[] color = new Color[2];
    int index = 0;



    void Start()
    {

        color[0] = Color.red;
        color[1] = Color.green;

        this.GetComponent<Renderer>().material.color = color[index];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer == 0)
        {
            this.GetComponent<ConstantForce>().enabled = false;

            if (num == 3)
            {

                Debug.Log("IN ");
                theDoor.GetComponent<DoorOpening>().enabled = true; // To open the door
                activeColorChange = false;

            }
 
        }
        else
        {
           
       
            if (num == 3)
            {
                Debug.Log("IN THE BEAST BELLY");
                theDoor.GetComponent<DoorOpening>().enabled = true; // To open the door
                activeColorChange = false;



            }
           
            timer--;
        }


    } 

    private void OnCollisionEnter(Collision collision)
    {
    
        if (timer == 0)
        {

            colorChange();
            thescore.AddScore(5);

         
        }
    

       
        this.GetComponent<AudioSource>().Play();
        this.GetComponent<ConstantForce>().enabled = true;
        timer = 3;
    
    
    }

    public static void increaseNum()
    { 
        num++;
        Debug.Log("VALUE OF NUM WHEN INCREASE NUM IS CALLED = "+ num);
    }
    public static void decreaseNum()
    {   
         num--;
        Debug.Log("VALUE OF NUM WHEN DECREASE NUM IS CALLED = " + num);
    }

    public void colorChange()
    {
        if (activeColorChange != false)
        {
            if (index < 1)
                index++;
            else
                index = 0;
            this.GetComponent<Renderer>().material.color = color[index];

            if (index == 1)
                increaseNum();
            else
                decreaseNum();
        }
    }

  


}
