using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject won;
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        won.SetActive(false);
        fire = GameObject.Find("Fireworks");
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        won.SetActive(true);
        fire.SetActive(true);
        Debug.Log(collision.collider);
    }
}
