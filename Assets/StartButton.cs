using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    private int timer=0;
    private Vector3 vec;
    private Quaternion quat;
    private static bool gameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        vec = camera1.transform.position;
        quat = camera1.transform.rotation;
        if(gameStarted)
        {
            camera1.transform.position =camera2.transform.position;
            camera1.transform.rotation = camera2.transform.rotation;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer>0)
        {
            timer--;
            camera1.transform.position = Vector3.Lerp(vec, camera2.transform.position, (500-timer)/500.0f);
            camera1.transform.rotation = Quaternion.Lerp(quat, camera2.transform.rotation, (500 - timer) / 500.0f);

        }

    }

    void OnMouseDown()
    {
        Debug.Log("Hello");
        timer = 500;
        gameStarted = true;
    }


}
