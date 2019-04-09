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
    Material[] color = new Material[2];
    public Material rouge;
    public Material vert;
    int index = 0;



    void Start()
    {
        num = 0;
        color[0] = rouge;
        color[1] = vert;

        this.GetComponent<Renderer>().material = color[index];
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 0)
        {
            this.GetComponent<ConstantForce>().enabled = false;

            if (num == 4)
            {

                Debug.Log("IN ");
                theDoor.GetComponent<DoorOpening>().enabled = true; // To open the door
                activeColorChange = false;

            }
 
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

            colorChange();
            thescore.AddScore(5);

         
        }
    

       
        this.GetComponent<AudioSource>().Play();
        this.GetComponent<ConstantForce>().enabled = true;
        timer = 3;
    
    
    }



    public void colorChange()
    {
        if (activeColorChange != false)
        {
            if (index < 1 && index>=0)
            {
                index++;
                updateNum();
                this.GetComponent<Renderer>().material = color[index];
            }
            else
            {
                index = 0;
                updateNum();
                this.GetComponent<Renderer>().material = color[index];
            }

        }
    }

    public void updateNum()
    {
        if (index == 1) // which means the bumper is green.
        {
            num++;
            Debug.Log("VALUE OF NUM WHEN INCREASE NUM IS CALLED = " + num);
        }
        else
        {
            num--;
            Debug.Log("VALUE OF NUM WHEN DECREASE NUM IS CALLED = " + num);
        }
    }




}
