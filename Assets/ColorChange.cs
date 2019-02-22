using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   
    float timer;
    public GameObject rb; 
    Color[] color = new Color[4];
    int index = 0;
    void Start()
    {   //rb= GameObject.Find("Bumper");
        color[0] = Color.blue;
        color[1] = Color.red;
        color[2] = Color.yellow;
        color[3] = Color.green;
        this.GetComponent<Renderer>().material.color = color[index];
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            if (index < 1)
                index++;
            else
                index = 0; 
            this.GetComponent<Renderer>().material.color = color[index];
            timer = 0;
        }
    }


}
