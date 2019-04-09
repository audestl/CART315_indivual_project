using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionScene : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    private int timer = 0;
    private Vector3 vec;
    private Quaternion quat;
    private static bool hasgameStarted = false;
    private int counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        vec = camera1.transform.position;
        quat = camera1.transform.rotation;
        if (hasgameStarted)
        {
            camera1.transform.position = camera3.transform.position;
            camera1.transform.rotation = camera3.transform.rotation;
        }

    }

    // Update is called once per frame
    void moveToPinball()
    {
        Debug.Log("Move");
        camera1.transform.position = Vector3.Lerp(vec, camera3.transform.position, (500 - timer) / 500.0f);
            camera1.transform.rotation = Quaternion.Lerp(quat, camera3.transform.rotation, (500 - timer) / 500.0f);

        Debug.Log("Value of counter =" + counter);

    }
    void moveToMenu()
    {
        Debug.Log("MoveBack");
        camera1.transform.position = Vector3.Lerp(vec, camera2.transform.position, (500 - timer) / 500.0f);
        camera1.transform.rotation = Quaternion.Lerp(quat, camera2.transform.rotation, (500 - timer) / 500.0f);
        Debug.Log("Value of counter =" +counter);



    }
    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.I.ToString())))
        {
            Debug.Log("Space key is pressed.");

            //hasgameStarted = true;
            if (hasgameStarted)
            {
                if (counter % 2 == 0)
                {
                    moveToPinball();
                    counter++;
                }
                else
                {

                    moveToMenu();
                    counter++;
                }
            }
        }
    }

}
