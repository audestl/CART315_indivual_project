using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Score thescore;
    public DoorOpening theDoor;

    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        theDoor.GetComponent<DoorOpening>().enabled = false;
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
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (timer == 0)
        {
            thescore.AddScore(5);
            thescore.Addmultiplier(1);
        }
        // if bumper is red when enter a collision, 
        if (GameObject.Find("Bumper").GetComponent<Renderer>().material.color == Color.red)
        { theDoor.GetComponent<DoorOpening>().enabled=true; 
        }

        this.GetComponent<AudioSource>().Play();
        this.GetComponent<ConstantForce>().enabled = true;
        timer = 3;
    }
}
