using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour

   
{
    float velo;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<AudioSource>().Play();
        collision.collider.attachedRigidbody.velocity += new Vector3(-50, 0, -50);
   
    }


}
