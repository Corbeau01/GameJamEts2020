using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanClimbOnit : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Mathf.Abs(player.transform.position.x - this.transform.position.x)<1f))
        {
            player.GetComponent<PlayerController>().CanClimb = true;
        }
        else
        {
            player.GetComponent<PlayerController>().CanClimb = false;
        }
    }
}
