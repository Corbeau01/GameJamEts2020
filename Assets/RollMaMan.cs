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
    bool HasReachEndOfJump = false;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
    }
    bool b1 = false;
    void Update()
    {if (VroomTarget == null)
        {
          //  VroomTarget = GameObject.Find("JumpPoint1").transform;
        }
        if(DropPoint!=null)
        {
            if (Vector2.Distance(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(DropPoint.transform.position.x, DropPoint.transform.position.y)) <= 10)
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
            if(b1==false)
            {
                player.transform.parent = this.gameObject.transform;
                player.GetComponent<Rigidbody>().useGravity = false;
                this.GetComponent<animatorStart>().GoJHonnyGo();
                b1 = true;
            }
            
        }
        
    }
    
}
