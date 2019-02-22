using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 myDoor;
    public Vector3 position;
    void Start()
    {
        this.GetComponent<DoorOpening>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.y > 0)
        {
            Debug.Log("going into");
            myDoor = transform.localScale;

            myDoor.y -= Time.deltaTime;
            // position.y -= myDoor.y * Time.deltaTime;
            transform.localScale = myDoor;
            transform.Translate(new Vector3(0, myDoor.y * Time.deltaTime*0.66f, 0), this.transform);
        }
    }







}
