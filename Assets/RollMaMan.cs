using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollMaMan : MonoBehaviour
{
    
    GameObject player;
    public Transform DropPoint;
    public Transform VroomTarget;
    bool cartIsInposition = false;
    public bool PlayerIsIn = false;
    bool HasReachEndOfJump=false;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
    }
    void Update()
    {
       if(VroomTarget==null)
        {
            VroomTarget = GameObject.Find("JumpPoint1").transform;
        }
        if(DropPoint!=null)
        {
            if (Vector2.Distance(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(DropPoint.transform.position.x, DropPoint.transform.position.y)) <= 4)
            {
                //DropPoint.color = Color.green;
                this.transform.position = DropPoint.position;
                cartIsInposition = true;

            }
            else
            {
                cartIsInposition = true;
            }
        }
        else
        {
            GameObject.Find("CartPD");
        }
        if(cartIsInposition&&PlayerIsIn)
        {
            print("Vroooooooooooooooooooooom");
            player.transform.parent = this.gameObject.transform;
            player.GetComponent<Rigidbody>().useGravity = false;
            Vector3.MoveTowards(DropPoint.position, VroomTarget.position, 1 * Time.deltaTime);
        }
        if(VroomTarget!=null)
        {
            if (Vector2.Distance(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(VroomTarget.transform.position.x, VroomTarget.transform.position.y)) <= 2)
            {
                //DropPoint.color = Color.green;
                print("vrom");
                HasReachEndOfJump = true;
                player.transform.parent = null;//become batman
                player.GetComponent<Rigidbody>().useGravity = true;
                //this.gameObject.transform.Translate(Vector3.down * 1* Time.deltaTime);
            }
        }
    }
}
