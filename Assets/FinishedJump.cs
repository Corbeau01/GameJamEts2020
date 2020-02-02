using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            print("Touched");
            this.transform.parent.GetComponent<PlayerController>().CanJump = true;
        }
        if (other.gameObject.tag == "Cart")
        {
            print("Playerisin");
            other.GetComponent<RollMaMan>().PlayerIsIn = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            print("Touched");
            GetComponent<PlayerController>().CanJump = true;
        }
    }
}
