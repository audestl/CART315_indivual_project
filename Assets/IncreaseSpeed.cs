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
        velo = collision.rigidbody.velocity.magnitude;
        Debug.Log(velo);
        Vector3 V3 = collision.rigidbody.velocity;
        V3 = (collision.transform.position - transform.position) *8;
        collision.rigidbody.velocity = V3;

        if (collision.rigidbody.velocity.magnitude < velo)
        {
            collision.rigidbody.velocity *= velo / collision.rigidbody.velocity.magnitude;
            Debug.Log("****");
        }
   
    }


}
