using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject won;
    //public GameObject fire;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        won.SetActive(false);
        //fire = GameObject.Find("Fireworks");
        //fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        won.SetActive(true);
        //fire.SetActive(true);
        this.GetComponent<AudioSource>().Play();
        Debug.Log(collision.collider);
        score.GetComponent<Score>().enabled = false;
    }
}
