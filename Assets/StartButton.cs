using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    private int timer=0;
    private Vector3 vec;
    private Quaternion quat;
    private static bool gameStarted = false;
    private int counter = 0;
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
        counter = 0;
    }

    void moveToPinball()
    {
        Debug.Log("Move");
        camera1.transform.position = Vector3.Lerp(vec, camera2.transform.position, (500 - timer) / 500.0f);
        camera1.transform.rotation = Quaternion.Lerp(quat, camera2.transform.rotation, (500 - timer) / 500.0f);

        Debug.Log("Value of counter =" + counter);

    }
    void moveToMenu()
    {
        Debug.Log("MoveBack");
        camera1.transform.position = Vector3.Lerp(vec, camera3.transform.position, (500 - timer) / 500.0f);
        camera1.transform.rotation = Quaternion.Lerp(quat, camera3.transform.rotation, (500 - timer) / 500.0f);
        Debug.Log("Value of counter =" + counter);



    }
    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.I.ToString())))
        {
            Debug.Log("Space key is pressed.");
            counter++;
            //hasgameStarted = true;
            if (gameStarted) // I am at the pinball and I try to go back to the menu by pressing I
            {
                if (counter % 2 == 1) // When counter is odd, move to Menu
                { 
                moveToMenu();
                }
                else
                {
                    moveToPinball();
                   

                }
            }
        }
    }



}
