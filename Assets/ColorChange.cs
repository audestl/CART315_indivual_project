using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChange : MonoBehaviour
{

    float timer;
  //  public GameObject rb;
    Color[] color = new Color[2];
    int index = 0;


    void Start()
    {   
        color[0] = Color.red;
        color[1] = Color.green;

        this.GetComponent<Renderer>().material.color = color[index];
    }

    void Update()
    {
        //timer += Time.deltaTime;
        //if (timer > 2)
        //{
        //    if (index < 1)
        //        index++;
        //    else
        //        index = 0;
        //    this.GetComponent<Renderer>().material.color = color[index];
        //    timer = 0;
        //}
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (index < 1)
            index++;
        else
            index = 0;
        this.GetComponent<Renderer>().material.color = color[index];

          if(index==1)              //if(this.GetComponent<Renderer>().material.color == color[1])
            Bumper.increaseNum();
        else
            Bumper.decreaseNum();

    }
}
