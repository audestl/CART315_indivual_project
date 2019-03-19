using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Score thescore;
    public DoorOpening theDoor;
   
    public static int num = 0;

    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Value of the variable num at the start=" + num + " ");
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
            Debug.Log(timer);
            timer--;
        }

        //Debug.Log("Value of the variable during game=" + num + " ");

        //if (this.GetComponent<Renderer>().material.color == Color.red)
        if (num == 3)
        {
            theDoor.GetComponent<DoorOpening>().enabled = true;
           
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("enter");
        if (timer == 0)
        {
            thescore.AddScore(5);
            thescore.Addmultiplier(1);
        }
        // if bumper is red when enter a collision,
       

        this.GetComponent<AudioSource>().Play();
        this.GetComponent<ConstantForce>().enabled = true;
        timer = 3;
    
    
    }

    public static void increaseNum()
    { 
        num++;
        //Debug.Log("VALUE OF NUM WHEN INCREASE NUM IS CALLED = "+ num);
    }
    public static void decreaseNum()
    {   
         num--;
        //Debug.Log("VALUE OF NUM WHEN DECREASE NUM IS CALLED = " + num);
    }
}
